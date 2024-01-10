using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace C__Yaml_Parser
{
    public partial class frmMain : Form
    {
        private const string KDefaultLayout = "post";
        private const string KDefaultAuthor = "Dan";
        private const string KDefaultCategory = "default";
        private const string KDateMask = "yyyy-MM-dd hh:mm tt";
        private const string KDefaultFolder = "C:\\Users\\dan\\OneDrive\\Desktop\\STAGING";
        private const string KTempFolder = "C:\\Users\\dan\\OneDrive\\Desktop\\STAGING_temp";
        private const string KDocStart = "---";
        private const string KDocEnd = "---";

        public frmMain()
        {
            InitializeComponent();

            LoadFilesFromFolder(KDefaultFolder);

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

        private void LoadFilesFromFolder(string folder)
        {
            //  clear the list 
            listFiles.Items.Clear();

            //  clear selection details
            ClearSelectionDetails();

            //  toggle editor states
            ToggleEditors(false);

            if (folder == null || folder == "")
                return;

            //  folder must exist
            if (!Directory.Exists(folder))
                return;

            //  load actual files
            DirectoryInfo di = new DirectoryInfo(folder);
            string filter = "*.md";
            if (!chkMarkdown.Checked)
                filter = "";
            FileInfo[] files = di.GetFiles(filter);
            foreach (FileInfo fi in files)
            {
                listFiles.Items.Add(fi.Name);
            }

            txtFolder.Text = folder;
        }

        private void ClearSelectionDetails()
        {
            txtFileName.Clear();
            txtContents.Clear();

            ClearYamlFields();
        }

        private void ToggleEditors(bool on)
        {
            txtFileName.Enabled = false;
            grpYaml.Enabled = on;
            btnSave.Enabled = on;
            txtContents.Enabled = false;
        }

        private void SetFrontMatterData(FrontMatterData data)
        {
            //  Clear Selection Data
            ClearSelectionDetails();

            if (data == null)
                return;

            txtTitle.Text = data.Title;
            txtAuthor.Text = data.Author;
            txtLayout.Text = data.Layout;
            txtDate.Text = data.Date;

            if (data.Categories != null)
            {
                foreach (string categ in data.Categories)
                {
                    chkListCategs.Items.Add(categ, true);
                }
            }

            //  Tags
        }

        private void LoadDefaultFrontMatter()
        {
            ClearYamlFields();

            if (listFiles.SelectedIndex != -1)
            {
                string item = listFiles.SelectedItem.ToString();

                txtTitle.Text = Path.GetFileNameWithoutExtension(item);
                txtDate.Text = DateTime.Now.ToString(KDateMask);
                txtLayout.Text = KDefaultLayout;
                txtAuthor.Text = KDefaultAuthor;

                chkListCategs.Items.Add(KDefaultCategory, true);
            }
        }

        private void LoadSelectionData(string fileName)
        {
            string path = txtFolder.Text + "\\" + fileName;
            string contents = txtContents.Text;

            try
            {
                var data = MarkdownExtensions.GetFrontMatter<FrontMatterData>(contents);

                SetFrontMatterData(data);
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

                LoadDefaultFrontMatter();
            }


        }

        private void ClearYamlFields()
        {
            txtTitle.Clear();
            txtLayout.Clear();
            txtAuthor.Clear();
            txtDate.Clear();
            chkListCategs.Items.Clear();
            //  clear tags
        }

        private void LoadFileContents(string fileName)
        {
            txtContents.Clear();
            txtContents.Text = File.ReadAllText(txtFolder.Text + "\\" + fileName);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                LoadFilesFromFolder(fbd.SelectedPath);
            }

        }

        private void chkMarkdown_CheckedChanged(object sender, EventArgs e)
        {
            //  reloads files from folder loading all or .md files only
            LoadFilesFromFolder(txtFolder.Text);
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFiles.SelectedIndex == -1)
                return;

            string fileName = listFiles.SelectedItem.ToString();

            LoadSelectionData(fileName);
            LoadFileContents(fileName);
            ToggleEditors(true);

            //  set file name last because it gets cleared when settin FM data
            txtFileName.Text = fileName;
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            LoadDefaultFrontMatter();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearYamlFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //  create the front matter structure
            FrontMatterData fm = new FrontMatterData();
            fm.Title = txtTitle.Text;
            fm.Author = txtAuthor.Text;
            fm.Layout = txtLayout.Text;
            fm.Date = txtDate.Text;

            //  save categories
            List<string> catList = new List<string>();
            foreach(string item in chkListCategs.CheckedItems)
            {
                catList.Add(item);
            }
            fm.Categories = catList.ToArray();

            //  serialize structure
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(fm);

            //  write to file            
            if (txtFileName.Text != null && txtFileName.Text != "")
            {
                string fileName = KTempFolder + "\\" + txtFileName.Text;

                StreamWriter writer = new StreamWriter(fileName);
                
                writer.WriteLine(KDocStart);
                writer.WriteLine(yaml);
                writer.WriteLine(KDocEnd);
                writer.WriteLine(txtContents.Text);
            }

        }
    }
}
