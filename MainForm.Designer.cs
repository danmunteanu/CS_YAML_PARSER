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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblFolder = new Label();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            chkMarkdownAndText = new CheckBox();
            listFiles = new ListBox();
            lblFileName = new Label();
            txtFileName = new TextBox();
            tableLayoutFileName = new TableLayoutPanel();
            txtContents = new TextBox();
            lblContents = new Label();
            btnSave = new Button();
            tableLayoutRight = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelYaml = new Panel();
            flowLayoutLanguages = new FlowLayoutPanel();
            lblLang = new Label();
            cmbLang = new ComboBox();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnClearList = new Button();
            lblListOfFiles = new Label();
            flowLayoutCheckboxes = new FlowLayoutPanel();
            chkIncludeSubfolders = new CheckBox();
            splitContainerMain = new SplitContainer();
            tableLayoutFileName.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutLanguages.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutCheckboxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(2, 506);
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
            txtFolder.Location = new Point(2, 532);
            txtFolder.Margin = new Padding(2);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(396, 27);
            txtFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Font = new Font("Segoe UI", 8F);
            btnBrowse.Location = new Point(2, 4);
            btnBrowse.Margin = new Padding(2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(125, 30);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "ADD FOLDER";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkMarkdownAndText
            // 
            chkMarkdownAndText.Anchor = AnchorStyles.Right;
            chkMarkdownAndText.AutoSize = true;
            chkMarkdownAndText.Checked = true;
            chkMarkdownAndText.CheckState = CheckState.Checked;
            chkMarkdownAndText.Location = new Point(162, 3);
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
            listFiles.AllowDrop = true;
            listFiles.Dock = DockStyle.Fill;
            listFiles.FormattingEnabled = true;
            listFiles.HorizontalScrollbar = true;
            listFiles.Location = new Point(2, 37);
            listFiles.Margin = new Padding(2);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(396, 457);
            listFiles.TabIndex = 5;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            listFiles.DragDrop += listFiles_DragDrop;
            listFiles.DragEnter += listFiles_DragEnter;
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
            txtFileName.Size = new Size(497, 27);
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
            tableLayoutFileName.Location = new Point(2, 47);
            tableLayoutFileName.Margin = new Padding(2);
            tableLayoutFileName.Name = "tableLayoutFileName";
            tableLayoutFileName.RowCount = 1;
            tableLayoutFileName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFileName.Size = new Size(600, 36);
            tableLayoutFileName.TabIndex = 8;
            // 
            // txtContents
            // 
            txtContents.Dock = DockStyle.Fill;
            txtContents.Location = new Point(2, 407);
            txtContents.Margin = new Padding(2);
            txtContents.Multiline = true;
            txtContents.Name = "txtContents";
            txtContents.ReadOnly = true;
            txtContents.ScrollBars = ScrollBars.Vertical;
            txtContents.Size = new Size(600, 197);
            txtContents.TabIndex = 10;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(2, 375);
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
            btnSave.Location = new Point(459, 2);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 44);
            btnSave.TabIndex = 12;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(tableLayoutPanel1, 0, 7);
            tableLayoutRight.Controls.Add(tableLayoutFileName, 0, 1);
            tableLayoutRight.Controls.Add(txtContents, 0, 6);
            tableLayoutRight.Controls.Add(lblContents, 0, 5);
            tableLayoutRight.Controls.Add(panelYaml, 0, 3);
            tableLayoutRight.Controls.Add(flowLayoutLanguages, 0, 0);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(0, 0);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 8;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutRight.Size = new Size(604, 661);
            tableLayoutRight.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 609);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(598, 49);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panelYaml
            // 
            panelYaml.Anchor = AnchorStyles.Left;
            panelYaml.Location = new Point(3, 108);
            panelYaml.Name = "panelYaml";
            panelYaml.Size = new Size(598, 244);
            panelYaml.TabIndex = 17;
            // 
            // flowLayoutLanguages
            // 
            flowLayoutLanguages.Controls.Add(lblLang);
            flowLayoutLanguages.Controls.Add(cmbLang);
            flowLayoutLanguages.Dock = DockStyle.Fill;
            flowLayoutLanguages.Location = new Point(3, 3);
            flowLayoutLanguages.Name = "flowLayoutLanguages";
            flowLayoutLanguages.Size = new Size(598, 39);
            flowLayoutLanguages.TabIndex = 18;
            // 
            // lblLang
            // 
            lblLang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLang.AutoSize = true;
            lblLang.Location = new Point(3, 7);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(77, 20);
            lblLang.TabIndex = 0;
            lblLang.Text = "Language:";
            // 
            // cmbLang
            // 
            cmbLang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLang.FormattingEnabled = true;
            cmbLang.Items.AddRange(new object[] { "EN - English", "RO - Romanian" });
            cmbLang.Location = new Point(86, 3);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(151, 28);
            cmbLang.TabIndex = 1;
            cmbLang.SelectedIndexChanged += cmbLang_SelectedIndexChanged;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(listFiles, 0, 1);
            tableLayoutLeft.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutLeft.Controls.Add(lblFolder, 0, 2);
            tableLayoutLeft.Controls.Add(txtFolder, 0, 3);
            tableLayoutLeft.Controls.Add(lblListOfFiles, 0, 0);
            tableLayoutLeft.Controls.Add(flowLayoutCheckboxes, 0, 5);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(0, 0);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 7;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutLeft.Size = new Size(400, 661);
            tableLayoutLeft.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.Controls.Add(btnBrowse, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClearList, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 569);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(394, 39);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // btnClearList
            // 
            btnClearList.Dock = DockStyle.Fill;
            btnClearList.Location = new Point(351, 3);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(40, 33);
            btnClearList.TabIndex = 0;
            btnClearList.Text = "🗑️";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // lblListOfFiles
            // 
            lblListOfFiles.Anchor = AnchorStyles.Left;
            lblListOfFiles.AutoSize = true;
            lblListOfFiles.Location = new Point(3, 7);
            lblListOfFiles.Name = "lblListOfFiles";
            lblListOfFiles.Size = new Size(83, 20);
            lblListOfFiles.TabIndex = 17;
            lblListOfFiles.Text = "List of files:";
            // 
            // flowLayoutCheckboxes
            // 
            flowLayoutCheckboxes.Controls.Add(chkIncludeSubfolders);
            flowLayoutCheckboxes.Controls.Add(chkMarkdownAndText);
            flowLayoutCheckboxes.Dock = DockStyle.Fill;
            flowLayoutCheckboxes.Location = new Point(3, 614);
            flowLayoutCheckboxes.Name = "flowLayoutCheckboxes";
            flowLayoutCheckboxes.Size = new Size(394, 34);
            flowLayoutCheckboxes.TabIndex = 18;
            // 
            // chkIncludeSubfolders
            // 
            chkIncludeSubfolders.AutoSize = true;
            chkIncludeSubfolders.Checked = true;
            chkIncludeSubfolders.CheckState = CheckState.Checked;
            chkIncludeSubfolders.Location = new Point(3, 3);
            chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            chkIncludeSubfolders.Size = new Size(154, 24);
            chkIncludeSubfolders.TabIndex = 0;
            chkIncludeSubfolders.Text = "Include Subfolders";
            chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(tableLayoutLeft);
            splitContainerMain.Panel1MinSize = 225;
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(tableLayoutRight);
            splitContainerMain.Panel2MinSize = 225;
            splitContainerMain.Size = new Size(1008, 661);
            splitContainerMain.SplitterDistance = 400;
            splitContainerMain.TabIndex = 14;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 661);
            Controls.Add(splitContainerMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "FrontMatter Loader (YAML)";
            tableLayoutFileName.ResumeLayout(false);
            tableLayoutFileName.PerformLayout();
            tableLayoutRight.ResumeLayout(false);
            tableLayoutRight.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutLanguages.ResumeLayout(false);
            flowLayoutLanguages.PerformLayout();
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutCheckboxes.ResumeLayout(false);
            flowLayoutCheckboxes.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
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
        private TextBox txtContents;
        private Label lblContents;
        private Button btnSave;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutRight;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnClearList;
        private Panel panelYaml;
        private Label lblListOfFiles;
        private FlowLayoutPanel flowLayoutCheckboxes;
        private CheckBox chkIncludeSubfolders;
        private SplitContainer splitContainerMain;
        private FlowLayoutPanel flowLayoutLanguages;
        private Label lblLang;
        private ComboBox cmbLang;
    }
}
