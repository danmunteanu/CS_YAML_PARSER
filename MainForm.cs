namespace C__Yaml_Parser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            LoadFilesFromFolder(@"C:\Users\dan\OneDrive\Desktop\STAGING");

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

        private void LoadFilesFromFolder (string folder)
        {
            if (folder == null || folder == "")
                return;

            //  clear the list 
            listFiles.Items.Clear();

            //  clear selection details
            ClearSelectionDetails();

            //  toggle editor states
            ToggleEditors(false);

            //  load actual files
            DirectoryInfo di = new DirectoryInfo(folder);
            string filter = "*.md";
            if (!chkMarkdown.Checked)
                filter = "";
            FileInfo[] files = di.GetFiles(filter);
            foreach(FileInfo fi in files)
            {
                listFiles.Items.Add(fi.Name);
            }

            txtFolder.Text = folder;
        }

        private void ClearSelectionDetails()
        {

        }

        private void ToggleEditors (bool on)
        {
            txtFileName.Enabled = on;
            grpYaml.Enabled = on;
            btnSave.Enabled = on;
            txtContents.Enabled = on;
        }

        private void LoadFileContents(string fileName)
        {
            txtContents.Clear();
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

            txtFileName.Text = listFiles.SelectedItem.ToString();

            //  load contents
            LoadFileContents(listFiles.SelectedItem.ToString());
        }
    }
}
