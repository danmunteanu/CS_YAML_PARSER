namespace C__Yaml_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFilesFromFolder (string folder)
        {
            if (folder == null || folder == "")
                return;

            //  clear the list 
            listFiles.Items.Clear();

            //  clear selection details
            ClearSelectionDetails();

            //  toggle editor states
            ToggleEditors();

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
        }

        private void ClearSelectionDetails()
        {

        }

        private void ToggleEditors ()
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                LoadFilesFromFolder(fbd.SelectedPath);
                txtFolder.Text = fbd.SelectedPath;
            }            
            
        }

        private void chkMarkdown_CheckedChanged(object sender, EventArgs e)
        {
            //  reloads files from folder loading all or .md files only
            LoadFilesFromFolder(txtFolder.Text);
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  when we select an item, we load the data into the selection panels
        }
    }
}
