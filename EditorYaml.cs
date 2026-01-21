using System.Windows.Forms.Design;
using System.ComponentModel;

namespace C__Yaml_Parser
{
    public partial class EditorYaml : UserControl
    {
        private const string KDefaultLayout = "post";
        private const string KDefaultAuthor = "Dan";
        private const string KDefaultCategory = "default";
        private const string KDateMask = "yyyy-MM-dd hh:mm tt";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FileName { get; set; } = "";

        public EditorYaml()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtTitle.Clear();
            txtLayout.Clear();
            txtAuthor.Clear();
            dpDate.Value = DateTime.Now;
            chkListCategs.Items.Clear();
            //  clear tags
        }

        public void LoadData(FrontMatterData data)
        {
            Clear();

            if (data == null)
                return;

            txtTitle.Text = data.Title;
            txtAuthor.Text = data.Author;
            txtLayout.Text = data.Layout;
            dpDate.Value = DateTime.Parse(data.Date);

            chkListCategs.Items.Clear();
            if (data.Categories != null)
            {
                foreach (string categ in data.Categories)
                {
                    chkListCategs.Items.Add(categ, true);
                }
            }

            //  Tags
        }

        public void SaveData(ref FrontMatterData fm)
        {
            fm.Title = txtTitle.Text;
            fm.Author = txtAuthor.Text;
            fm.Layout = txtLayout.Text;
            fm.Date = dpDate.Value.ToString();

            //  save categories
            List<string> catList = new List<string>();
            foreach (string item in chkListCategs.CheckedItems)
            {
                catList.Add(item);
            }
            fm.Categories = catList.ToArray();
        }
        public void LoadDefaults()
        {
            Clear();

            if (!string.IsNullOrEmpty(FileName))
                txtTitle.Text = Path.GetFileNameWithoutExtension(FileName);

            dpDate.Value = DateTime.Now;
            txtLayout.Text = KDefaultLayout;
            txtAuthor.Text = KDefaultAuthor;

            chkListCategs.Items.Add(KDefaultCategory, true);
        }
        private void btnDefaults_Click(object sender, EventArgs e)
        {
            LoadDefaults();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void UpdateLocale()
        {
            //  Fields
            lblTitle.Text = Locale.LBL_YAML_TITLE;
            lblAuthor.Text = Locale.LBL_YAML_AUTHOR;
            lblLayout.Text = Locale.LBL_YAML_LAYOUT;
            lblDate.Text = Locale.LBL_YAML_DATE;

            //  Categories
            lblCategs.Text = Locale.LBL_YAML_CATEGORIES;

            //  Buttons
            btnDefaults.Text = Locale.LBL_YAML_BTN_DEFAULTS;
            btnClear.Text = Locale.LBL_YAML_BTN_CLEAR;
        }
    }
}
