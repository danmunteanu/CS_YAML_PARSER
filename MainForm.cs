using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace C__Yaml_Parser
{
    public partial class frmMain : Form
    {
        private const string KDocEnd = "---";
        private const string KDocStart = "---";

        private EditorYaml _editorYaml = new();

        private string KDefaultFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                ""  //  Add subfolder here
            );

        private string KTempFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "STAGING_temp"
            );

        private string[] s_AllowedExtensions = [
            ".md",
            ".markdown",
            ".txt",
        ];

        public frmMain()
        {
            InitializeComponent();
            
            //  Add _editorYaml to form
            _editorYaml.Dock = DockStyle.Fill;
            panelYaml.Controls.Clear();
            panelYaml.Controls.Add(_editorYaml);
            _editorYaml.BringToFront();

            OnBrowse(KDefaultFolder);

            this.CenterToScreen();
        }

        /*
            On list selection changed:
                - load file name
                - load contents
                - try to detect front matter data in the .md file
                    if found -> load data into the interface
                        - author
                        - title
                        - layout
                        - date
                        - categories
                        - etc.
                    if not found?
                        - load defaults
         */

        private void OnBrowse(string folder)
        {
            //  clear the list 
            listFiles.Items.Clear();

            //  clear selection details
            ClearSelectionDetails();

            //  toggle editor states
            ToggleEditors(false);

            if (string.IsNullOrEmpty(folder))
                return;

            //  folder must exist
            if (!Directory.Exists(folder))
                return;

            LoadFilesFromFolder(folder);

            txtFolder.Text = folder;
        }

        private void LoadFilesFromFolder(string folder)
        {
            //  load actual files
            DirectoryInfo di = new DirectoryInfo(folder);
            IEnumerable<FileInfo> files = di.EnumerateFiles();
            if (chkMarkdownAndText.Checked)
            {
                files = files.Where(
                    f => s_AllowedExtensions.Contains(f.Extension)
                );
            }
            foreach (FileInfo file in files)
                listFiles.Items.Add(file.FullName);

            if (chkIncludeSubfolders.Checked)
            {
                //  load subfolders
                IEnumerable<DirectoryInfo> subdirs = di.EnumerateDirectories();
                foreach (DirectoryInfo sdi in subdirs)
                {
                    LoadFilesFromFolder(sdi.FullName);
                }
            }
        }

        private void ClearSelectionDetails()
        {
            txtFileName.Clear();

            _editorYaml.Clear();

            txtContents.Clear();
        }

        private void ToggleEditors(bool on)
        {
            txtFileName.Enabled = false;

            _editorYaml.Enabled = on;

            //txtContents.Enabled = false;

            btnSave.Enabled = on;
        }

        private void LoadSelectionData(string fileName)
        {
            string path = Path.Combine(txtFolder.Text, fileName);
            string contents = txtContents.Text;

            _editorYaml.FileName = fileName;

            try
            {
                var data = MarkdownExtensions.GetFrontMatter<FrontMatterData>(contents);

                _editorYaml.LoadData(data);
            }
            catch (Exception ex)
            {
                DialogResult res;
                res = MessageBox.Show(
                    ex.ToString(),
                    "Exception Thrown",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _editorYaml.LoadDefaults();
            }


        }


        private void LoadFileContents(string fileName)
        {
            txtContents.Clear();
            txtContents.Text = File.ReadAllText(Path.Combine(txtFolder.Text, fileName));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                OnBrowse(fbd.SelectedPath);
            }

        }

        private void chkMarkdown_CheckedChanged(object sender, EventArgs e)
        {
            //  reloads files from folder loading all or .md files only
            OnBrowse(txtFolder.Text);
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFiles.SelectedIndex == -1)
                return;

            if (listFiles.SelectedItem is not string selected)
                return;

            string fileName = Path.GetFileName(selected.ToString());
            string ext = Path.GetExtension(fileName).ToLowerInvariant();

            //  make sure we're loading only text-files
            if (!s_AllowedExtensions.Contains(ext))
            {
                _editorYaml.Clear();
                ToggleEditors(false);
                txtFileName.Text = fileName;
                txtContents.Text = string.Empty;
                return;
            }

            LoadFileContents(fileName);
            LoadSelectionData(fileName);
            ToggleEditors(true);

            //  set file name last because it gets cleared when settin FM data
            txtFileName.Text = fileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ext = Path.GetExtension(txtFileName.Text).ToLowerInvariant();
            if (!s_AllowedExtensions.Contains(ext))
            {
                string message = string.Format("Saving to a {0} file is not allowed", ext);
                string title = "Cannot save";
                MessageBox.Show(message, title);
                return;
            }

            //  create the front matter structure
            FrontMatterData fm = new FrontMatterData();
            _editorYaml.SaveData(ref fm);

            //  serialize structure
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(fm);

            //  write to file            
            if (txtFileName.Text != null && txtFileName.Text != "")
            {
                if (!Directory.Exists(KTempFolder))
                {
                    Directory.CreateDirectory(KTempFolder);
                }

                string fileName = Path.Combine(KTempFolder, txtFileName.Text);

                StreamWriter writer = new StreamWriter(fileName);

                writer.WriteLine(KDocStart);
                writer.WriteLine(yaml);
                writer.WriteLine(KDocEnd);
                writer.WriteLine(txtContents.Text);

                writer.Flush();
            }

        }

        private void listFiles_DragEnter(object sender, DragEventArgs e)
        {
            //  set the drag drop effects based on the selection

            e.Effect = DragDropEffects.None;

            if (e.Data is null)
                return;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            if (e.Data.GetData(DataFormats.FileDrop) is not string[] dropItems ||
                dropItems.Length == 0)
                return;

            foreach (string item in dropItems)
            {
                if (Directory.Exists(item))
                {
                    e.Effect = DragDropEffects.All;
                    continue;
                }

                string ext = Path.GetExtension(item).ToLowerInvariant();

                if (chkMarkdownAndText.Checked)
                {
                    if (s_AllowedExtensions.Contains(ext))
                    {
                        e.Effect = DragDropEffects.All;
                        continue;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.All;
                    continue;
                }
            }
        }

        private void listFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            if (e.Data.GetData(DataFormats.FileDrop) is not string[] dropItems ||
                dropItems.Length == 0)
                return;

            foreach (string item in dropItems)
            {
                if (Directory.Exists(item))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    IEnumerable<FileInfo> files = di.EnumerateFiles();
                    if (chkMarkdownAndText.Checked)
                    {
                        files = files.Where(
                            f => s_AllowedExtensions.Contains(f.Extension)
                        );
                    }
                    foreach (FileInfo file in files)
                        listFiles.Items.Add(file.FullName);

                    continue;
                }

                string ext = Path.GetExtension(item).ToLowerInvariant();

                if (chkMarkdownAndText.Checked)
                {
                    if (s_AllowedExtensions.Contains(ext))
                    {
                        listFiles.Items.Add(item);
                        continue;
                    }
                }
                else
                {
                    listFiles.Items.Add(item);
                    continue;
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Clear list?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;

            listFiles.Items.Clear();
            txtFolder.Text = string.Empty;
            ClearSelectionDetails();
            ToggleEditors(false);
        }
    }
}
