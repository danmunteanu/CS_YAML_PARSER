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
            chkMarkdown = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            listFiles = new ListBox();
            lblFileName = new Label();
            txtFileName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            grpYaml = new GroupBox();
            btnDefaults = new Button();
            btnClear = new Button();
            lblDate = new Label();
            txtDate = new TextBox();
            txtLayout = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            lblCategs = new Label();
            chkListCategs = new CheckedListBox();
            lblLayout = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            txtContents = new TextBox();
            lblContents = new Label();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpYaml.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(3, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(66, 25);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Enabled = false;
            txtFolder.Location = new Point(99, 3);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(617, 31);
            txtFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(722, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkMarkdown
            // 
            chkMarkdown.AutoSize = true;
            chkMarkdown.Checked = true;
            chkMarkdown.CheckState = CheckState.Checked;
            chkMarkdown.Location = new Point(853, 3);
            chkMarkdown.Name = "chkMarkdown";
            chkMarkdown.Size = new Size(219, 29);
            chkMarkdown.TabIndex = 3;
            chkMarkdown.Text = "Markdown Only (*.md)";
            chkMarkdown.UseVisualStyleBackColor = true;
            chkMarkdown.CheckedChanged += chkMarkdown_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.35807F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.64193F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel1.Controls.Add(lblFolder, 0, 0);
            tableLayoutPanel1.Controls.Add(chkMarkdown, 3, 0);
            tableLayoutPanel1.Controls.Add(txtFolder, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBrowse, 2, 0);
            tableLayoutPanel1.Location = new Point(36, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1094, 49);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // listFiles
            // 
            listFiles.FormattingEnabled = true;
            listFiles.ItemHeight = 25;
            listFiles.Location = new Point(36, 99);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(400, 629);
            listFiles.TabIndex = 5;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(3, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(94, 25);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(134, 3);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(543, 31);
            txtFileName.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.29499F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.70501F));
            tableLayoutPanel2.Controls.Add(lblFileName, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFileName, 1, 0);
            tableLayoutPanel2.Location = new Point(453, 96);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(680, 55);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // grpYaml
            // 
            grpYaml.Controls.Add(btnDefaults);
            grpYaml.Controls.Add(btnClear);
            grpYaml.Controls.Add(lblDate);
            grpYaml.Controls.Add(txtDate);
            grpYaml.Controls.Add(txtLayout);
            grpYaml.Controls.Add(txtAuthor);
            grpYaml.Controls.Add(txtTitle);
            grpYaml.Controls.Add(lblCategs);
            grpYaml.Controls.Add(chkListCategs);
            grpYaml.Controls.Add(lblLayout);
            grpYaml.Controls.Add(lblAuthor);
            grpYaml.Controls.Add(lblTitle);
            grpYaml.Location = new Point(456, 157);
            grpYaml.Name = "grpYaml";
            grpYaml.Size = new Size(677, 343);
            grpYaml.TabIndex = 9;
            grpYaml.TabStop = false;
            grpYaml.Text = "Yaml Data (FrontMatter)";
            // 
            // btnDefaults
            // 
            btnDefaults.Location = new Point(304, 268);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(163, 34);
            btnDefaults.TabIndex = 11;
            btnDefaults.Text = "Defaults";
            btnDefaults.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(524, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 205);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(53, 25);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Location = new Point(139, 199);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 31);
            txtDate.TabIndex = 8;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(139, 142);
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(150, 31);
            txtLayout.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(138, 96);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(139, 53);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 5;
            // 
            // lblCategs
            // 
            lblCategs.AutoSize = true;
            lblCategs.Location = new Point(328, 39);
            lblCategs.Name = "lblCategs";
            lblCategs.Size = new Size(100, 25);
            lblCategs.TabIndex = 4;
            lblCategs.Text = "Categories:";
            // 
            // chkListCategs
            // 
            chkListCategs.FormattingEnabled = true;
            chkListCategs.Location = new Point(328, 67);
            chkListCategs.Name = "chkListCategs";
            chkListCategs.Size = new Size(156, 144);
            chkListCategs.TabIndex = 3;
            // 
            // lblLayout
            // 
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(24, 143);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(69, 25);
            lblLayout.TabIndex = 2;
            lblLayout.Text = "Layout:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(26, 94);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(71, 25);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(48, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // txtContents
            // 
            txtContents.Location = new Point(456, 531);
            txtContents.Multiline = true;
            txtContents.Name = "txtContents";
            txtContents.Size = new Size(677, 201);
            txtContents.TabIndex = 10;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(456, 503);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(87, 25);
            lblContents.TabIndex = 11;
            lblContents.Text = "Contents:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(980, 747);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 800);
            Controls.Add(btnSave);
            Controls.Add(lblContents);
            Controls.Add(txtContents);
            Controls.Add(grpYaml);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(listFiles);
            Controls.Add(tableLayoutPanel1);
            Name = "frmMain";
            Text = "FrontMatter Loader (YAML)";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpYaml.ResumeLayout(false);
            grpYaml.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private TextBox txtFolder;
        private Button btnBrowse;
        private CheckBox chkMarkdown;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listFiles;
        private Label lblFileName;
        private TextBox txtFileName;
        private TableLayoutPanel tableLayoutPanel2;
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
    }
}
