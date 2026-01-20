namespace C__Yaml_Parser
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFolder = new Label();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            chkMarkdownAndText = new CheckBox();
            listFiles = new ListBox();
            lblFileName = new Label();
            txtFileName = new TextBox();
            tableLayoutFileName = new TableLayoutPanel();
            grpYaml = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutYamlLeft = new TableLayoutPanel();
            txtDate = new TextBox();
            lblDate = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtLayout = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblLayout = new Label();
            tableLayoutYamlRight = new TableLayoutPanel();
            lblCategs = new Label();
            chkListCategs = new CheckedListBox();
            btnDefaults = new Button();
            btnClear = new Button();
            txtContents = new TextBox();
            lblContents = new Label();
            btnSave = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutRight = new TableLayoutPanel();
            tableLayoutYAML = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutBottom = new TableLayoutPanel();
            tableLayoutFileName.SuspendLayout();
            grpYaml.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutYamlLeft.SuspendLayout();
            tableLayoutYamlRight.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            tableLayoutYAML.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            tableLayoutBottom.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(2, 507);
            lblFolder.Margin = new Padding(2, 0, 2, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(54, 20);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Enabled = false;
            txtFolder.Location = new Point(2, 531);
            txtFolder.Margin = new Padding(2);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(396, 27);
            txtFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Font = new Font("Segoe UI", 8F);
            btnBrowse.Location = new Point(2, 2);
            btnBrowse.Margin = new Padding(2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(113, 35);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "ADD FOLDER";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkMarkdownAndText
            // 
            chkMarkdownAndText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkMarkdownAndText.AutoSize = true;
            chkMarkdownAndText.Checked = true;
            chkMarkdownAndText.CheckState = CheckState.Checked;
            chkMarkdownAndText.Location = new Point(195, 7);
            chkMarkdownAndText.Margin = new Padding(2);
            chkMarkdownAndText.Name = "chkMarkdownAndText";
            chkMarkdownAndText.Size = new Size(197, 24);
            chkMarkdownAndText.TabIndex = 3;
            chkMarkdownAndText.Text = "Markdown And Text Only";
            chkMarkdownAndText.UseVisualStyleBackColor = true;
            chkMarkdownAndText.CheckedChanged += chkMarkdown_CheckedChanged;
            // 
            // listFiles
            // 
            listFiles.Dock = DockStyle.Fill;
            listFiles.FormattingEnabled = true;
            listFiles.Location = new Point(2, 2);
            listFiles.Margin = new Padding(2);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(396, 493);
            listFiles.TabIndex = 5;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.Right;
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(18, 8);
            lblFileName.Margin = new Padding(2, 0, 2, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(79, 20);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(101, 4);
            txtFileName.Margin = new Padding(2);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(394, 27);
            txtFileName.TabIndex = 7;
            // 
            // tableLayoutFileName
            // 
            tableLayoutFileName.ColumnCount = 2;
            tableLayoutFileName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutFileName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFileName.Controls.Add(lblFileName, 0, 0);
            tableLayoutFileName.Controls.Add(txtFileName, 1, 0);
            tableLayoutFileName.Dock = DockStyle.Fill;
            tableLayoutFileName.Location = new Point(2, 2);
            tableLayoutFileName.Margin = new Padding(2);
            tableLayoutFileName.Name = "tableLayoutFileName";
            tableLayoutFileName.RowCount = 1;
            tableLayoutFileName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFileName.Size = new Size(497, 36);
            tableLayoutFileName.TabIndex = 8;
            // 
            // grpYaml
            // 
            grpYaml.Controls.Add(tableLayoutPanel4);
            grpYaml.Dock = DockStyle.Fill;
            grpYaml.Location = new Point(2, 2);
            grpYaml.Margin = new Padding(2);
            grpYaml.Name = "grpYaml";
            grpYaml.Padding = new Padding(2);
            grpYaml.Size = new Size(491, 195);
            grpYaml.TabIndex = 9;
            grpYaml.TabStop = false;
            grpYaml.Text = "Yaml Data (FrontMatter)";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel4.Controls.Add(tableLayoutYamlLeft, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutYamlRight, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(487, 171);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // tableLayoutYamlLeft
            // 
            tableLayoutYamlLeft.ColumnCount = 2;
            tableLayoutYamlLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutYamlLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutYamlLeft.Controls.Add(txtDate, 1, 3);
            tableLayoutYamlLeft.Controls.Add(lblDate, 0, 3);
            tableLayoutYamlLeft.Controls.Add(lblTitle, 0, 0);
            tableLayoutYamlLeft.Controls.Add(txtTitle, 1, 0);
            tableLayoutYamlLeft.Controls.Add(txtLayout, 1, 2);
            tableLayoutYamlLeft.Controls.Add(lblAuthor, 0, 1);
            tableLayoutYamlLeft.Controls.Add(txtAuthor, 1, 1);
            tableLayoutYamlLeft.Controls.Add(lblLayout, 0, 2);
            tableLayoutYamlLeft.Dock = DockStyle.Fill;
            tableLayoutYamlLeft.Location = new Point(3, 3);
            tableLayoutYamlLeft.Name = "tableLayoutYamlLeft";
            tableLayoutYamlLeft.RowCount = 5;
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutYamlLeft.Size = new Size(314, 165);
            tableLayoutYamlLeft.TabIndex = 16;
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Location = new Point(92, 92);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(193, 27);
            txtDate.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 95);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(47, 5);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(92, 2);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(92, 62);
            txtLayout.Margin = new Padding(2);
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(110, 27);
            txtLayout.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Right;
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(31, 35);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(92, 32);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(110, 27);
            txtAuthor.TabIndex = 6;
            // 
            // lblLayout
            // 
            lblLayout.Anchor = AnchorStyles.Right;
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(32, 65);
            lblLayout.Margin = new Padding(2, 0, 2, 0);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(56, 20);
            lblLayout.TabIndex = 2;
            lblLayout.Text = "Layout:";
            // 
            // tableLayoutYamlRight
            // 
            tableLayoutYamlRight.ColumnCount = 1;
            tableLayoutYamlRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutYamlRight.Controls.Add(lblCategs, 0, 0);
            tableLayoutYamlRight.Controls.Add(chkListCategs, 0, 1);
            tableLayoutYamlRight.Dock = DockStyle.Fill;
            tableLayoutYamlRight.Location = new Point(325, 3);
            tableLayoutYamlRight.Name = "tableLayoutYamlRight";
            tableLayoutYamlRight.RowCount = 2;
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutYamlRight.Size = new Size(159, 165);
            tableLayoutYamlRight.TabIndex = 17;
            // 
            // lblCategs
            // 
            lblCategs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategs.AutoSize = true;
            lblCategs.Location = new Point(2, 10);
            lblCategs.Margin = new Padding(2, 0, 2, 0);
            lblCategs.Name = "lblCategs";
            lblCategs.Size = new Size(83, 20);
            lblCategs.TabIndex = 4;
            lblCategs.Text = "Categories:";
            // 
            // chkListCategs
            // 
            chkListCategs.Dock = DockStyle.Fill;
            chkListCategs.FormattingEnabled = true;
            chkListCategs.Location = new Point(2, 32);
            chkListCategs.Margin = new Padding(2);
            chkListCategs.Name = "chkListCategs";
            chkListCategs.Size = new Size(155, 131);
            chkListCategs.TabIndex = 3;
            // 
            // btnDefaults
            // 
            btnDefaults.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaults.Font = new Font("Segoe UI", 8F);
            btnDefaults.Location = new Point(322, 6);
            btnDefaults.Margin = new Padding(2);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(92, 27);
            btnDefaults.TabIndex = 11;
            btnDefaults.Text = "DEFAULTS";
            btnDefaults.UseVisualStyleBackColor = true;
            btnDefaults.Click += btnDefaults_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(418, 6);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 27);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtContents
            // 
            txtContents.Dock = DockStyle.Fill;
            txtContents.Location = new Point(2, 322);
            txtContents.Margin = new Padding(2);
            txtContents.Multiline = true;
            txtContents.Name = "txtContents";
            txtContents.ReadOnly = true;
            txtContents.ScrollBars = ScrollBars.Vertical;
            txtContents.Size = new Size(497, 228);
            txtContents.TabIndex = 10;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(2, 290);
            lblContents.Margin = new Padding(2, 0, 2, 0);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(70, 20);
            lblContents.TabIndex = 11;
            lblContents.Text = "Contents:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Location = new Point(356, 2);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 44);
            btnSave.TabIndex = 12;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.53303F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.46697F));
            tableLayoutMain.Controls.Add(tableLayoutRight, 1, 0);
            tableLayoutMain.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(913, 613);
            tableLayoutMain.TabIndex = 13;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutRight.Controls.Add(tableLayoutYAML, 0, 1);
            tableLayoutRight.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutRight.Controls.Add(tableLayoutFileName, 0, 0);
            tableLayoutRight.Controls.Add(txtContents, 0, 3);
            tableLayoutRight.Controls.Add(lblContents, 0, 2);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(409, 3);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 5;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutRight.Size = new Size(501, 607);
            tableLayoutRight.TabIndex = 15;
            // 
            // tableLayoutYAML
            // 
            tableLayoutYAML.ColumnCount = 1;
            tableLayoutYAML.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutYAML.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutYAML.Controls.Add(grpYaml, 0, 0);
            tableLayoutYAML.Dock = DockStyle.Fill;
            tableLayoutYAML.Location = new Point(3, 43);
            tableLayoutYAML.Name = "tableLayoutYAML";
            tableLayoutYAML.RowCount = 2;
            tableLayoutYAML.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutYAML.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutYAML.Size = new Size(495, 244);
            tableLayoutYAML.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel3.Controls.Add(btnDefaults, 1, 0);
            tableLayoutPanel3.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 202);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(489, 39);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 555);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(495, 49);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(tableLayoutBottom, 0, 3);
            tableLayoutLeft.Controls.Add(listFiles, 0, 0);
            tableLayoutLeft.Controls.Add(lblFolder, 0, 1);
            tableLayoutLeft.Controls.Add(txtFolder, 0, 2);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 3);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 4;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.Size = new Size(400, 607);
            tableLayoutLeft.TabIndex = 14;
            // 
            // tableLayoutBottom
            // 
            tableLayoutBottom.ColumnCount = 3;
            tableLayoutBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tableLayoutBottom.Controls.Add(btnBrowse, 0, 0);
            tableLayoutBottom.Controls.Add(chkMarkdownAndText, 2, 0);
            tableLayoutBottom.Dock = DockStyle.Fill;
            tableLayoutBottom.Location = new Point(3, 565);
            tableLayoutBottom.Name = "tableLayoutBottom";
            tableLayoutBottom.RowCount = 1;
            tableLayoutBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBottom.Size = new Size(394, 39);
            tableLayoutBottom.TabIndex = 15;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 613);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "FrontMatter Loader (YAML)";
            tableLayoutFileName.ResumeLayout(false);
            tableLayoutFileName.PerformLayout();
            grpYaml.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutYamlLeft.ResumeLayout(false);
            tableLayoutYamlLeft.PerformLayout();
            tableLayoutYamlRight.ResumeLayout(false);
            tableLayoutYamlRight.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutRight.ResumeLayout(false);
            tableLayoutRight.PerformLayout();
            tableLayoutYAML.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            tableLayoutBottom.ResumeLayout(false);
            tableLayoutBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFolder;
        private TextBox txtFolder;
        private Button btnBrowse;
        private CheckBox chkMarkdownAndText;
        private ListBox listFiles;
        private Label lblFileName;
        private TextBox txtFileName;
        private TableLayoutPanel tableLayoutFileName;
        private GroupBox grpYaml;
        private Button btnDefaults;
        private Button btnClear;
        private Label lblDate;
        private TextBox txtDate;
        private TextBox txtLayout;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label lblCategs;
        private CheckedListBox chkListCategs;
        private Label lblLayout;
        private Label lblAuthor;
        private Label lblTitle;
        private TextBox txtContents;
        private Label lblContents;
        private Button btnSave;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutBottom;
        private TableLayoutPanel tableLayoutRight;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutYamlLeft;
        private TableLayoutPanel tableLayoutYamlRight;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutYAML;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
