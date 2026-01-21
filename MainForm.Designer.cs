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
            txtContents = new TextBox();
            lblContents = new Label();
            btnSave = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutRight = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelYaml = new Panel();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnClearList = new Button();
            label1 = new Label();
            tableLayoutFileName.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(2, 540);
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
            txtFolder.Location = new Point(2, 566);
            txtFolder.Margin = new Padding(2);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(438, 27);
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
            chkMarkdownAndText.Location = new Point(202, 7);
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
            listFiles.Size = new Size(438, 491);
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
            txtFileName.Size = new Size(447, 27);
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
            tableLayoutFileName.Location = new Point(2, 37);
            tableLayoutFileName.Margin = new Padding(2);
            tableLayoutFileName.Name = "tableLayoutFileName";
            tableLayoutFileName.RowCount = 1;
            tableLayoutFileName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFileName.Size = new Size(550, 36);
            tableLayoutFileName.TabIndex = 8;
            // 
            // txtContents
            // 
            txtContents.Dock = DockStyle.Fill;
            txtContents.Location = new Point(2, 397);
            txtContents.Margin = new Padding(2);
            txtContents.Multiline = true;
            txtContents.Name = "txtContents";
            txtContents.ReadOnly = true;
            txtContents.ScrollBars = ScrollBars.Vertical;
            txtContents.Size = new Size(550, 201);
            txtContents.TabIndex = 10;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(2, 365);
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
            btnSave.Location = new Point(409, 2);
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
            tableLayoutMain.Size = new Size(1008, 661);
            tableLayoutMain.TabIndex = 13;
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
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(451, 3);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 8;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutRight.Size = new Size(554, 655);
            tableLayoutRight.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 603);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(548, 49);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panelYaml
            // 
            panelYaml.Dock = DockStyle.Fill;
            panelYaml.Location = new Point(3, 98);
            panelYaml.Name = "panelYaml";
            panelYaml.Size = new Size(548, 244);
            panelYaml.TabIndex = 17;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(listFiles, 0, 1);
            tableLayoutLeft.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutLeft.Controls.Add(lblFolder, 0, 2);
            tableLayoutLeft.Controls.Add(txtFolder, 0, 3);
            tableLayoutLeft.Controls.Add(label1, 0, 0);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 3);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 6;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutLeft.Size = new Size(442, 655);
            tableLayoutLeft.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Controls.Add(chkMarkdownAndText, 1, 0);
            tableLayoutPanel2.Controls.Add(btnBrowse, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClearList, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 603);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(436, 39);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(404, 3);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(29, 28);
            btnClearList.TabIndex = 0;
            btnClearList.Text = "X";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 17;
            label1.Text = "List of files:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 661);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "FrontMatter Loader (YAML)";
            tableLayoutFileName.ResumeLayout(false);
            tableLayoutFileName.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutRight.ResumeLayout(false);
            tableLayoutRight.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutRight;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnClearList;
        private Panel panelYaml;
        private Label label1;
    }
}
