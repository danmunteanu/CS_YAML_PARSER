namespace C__Yaml_Parser
{
    partial class EditorYaml
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpYaml = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutYamlRight = new TableLayoutPanel();
            lblCategs = new Label();
            chkListCategs = new CheckedListBox();
            tableLayoutYamlLeft = new TableLayoutPanel();
            flowLayoutButtons = new FlowLayoutPanel();
            btnDefaults = new Button();
            btnClear = new Button();
            lblDate = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtLayout = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblLayout = new Label();
            dpDate = new DateTimePicker();
            grpYaml.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutYamlRight.SuspendLayout();
            tableLayoutYamlLeft.SuspendLayout();
            flowLayoutButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpYaml
            // 
            grpYaml.Controls.Add(tableLayoutPanel4);
            grpYaml.Dock = DockStyle.Fill;
            grpYaml.Location = new Point(0, 0);
            grpYaml.Margin = new Padding(2);
            grpYaml.Name = "grpYaml";
            grpYaml.Padding = new Padding(2);
            grpYaml.Size = new Size(533, 268);
            grpYaml.TabIndex = 10;
            grpYaml.TabStop = false;
            grpYaml.Text = "Yaml Data (FrontMatter)";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 346F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel4.Controls.Add(tableLayoutYamlRight, 2, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutYamlLeft, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(529, 244);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // tableLayoutYamlRight
            // 
            tableLayoutYamlRight.ColumnCount = 1;
            tableLayoutYamlRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutYamlRight.Controls.Add(lblCategs, 0, 0);
            tableLayoutYamlRight.Controls.Add(chkListCategs, 0, 1);
            tableLayoutYamlRight.Dock = DockStyle.Fill;
            tableLayoutYamlRight.Location = new Point(367, 3);
            tableLayoutYamlRight.Name = "tableLayoutYamlRight";
            tableLayoutYamlRight.RowCount = 3;
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutYamlRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutYamlRight.Size = new Size(159, 238);
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
            chkListCategs.Size = new Size(155, 116);
            chkListCategs.TabIndex = 3;
            // 
            // tableLayoutYamlLeft
            // 
            tableLayoutYamlLeft.ColumnCount = 2;
            tableLayoutYamlLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutYamlLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutYamlLeft.Controls.Add(flowLayoutButtons, 1, 5);
            tableLayoutYamlLeft.Controls.Add(lblDate, 0, 4);
            tableLayoutYamlLeft.Controls.Add(lblTitle, 0, 1);
            tableLayoutYamlLeft.Controls.Add(txtTitle, 1, 1);
            tableLayoutYamlLeft.Controls.Add(txtLayout, 1, 3);
            tableLayoutYamlLeft.Controls.Add(lblAuthor, 0, 2);
            tableLayoutYamlLeft.Controls.Add(txtAuthor, 1, 2);
            tableLayoutYamlLeft.Controls.Add(lblLayout, 0, 3);
            tableLayoutYamlLeft.Controls.Add(dpDate, 1, 4);
            tableLayoutYamlLeft.Dock = DockStyle.Fill;
            tableLayoutYamlLeft.Location = new Point(3, 3);
            tableLayoutYamlLeft.Name = "tableLayoutYamlLeft";
            tableLayoutYamlLeft.RowCount = 6;
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutYamlLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutYamlLeft.Size = new Size(340, 238);
            tableLayoutYamlLeft.TabIndex = 16;
            // 
            // flowLayoutButtons
            // 
            flowLayoutButtons.Controls.Add(btnDefaults);
            flowLayoutButtons.Controls.Add(btnClear);
            flowLayoutButtons.Dock = DockStyle.Fill;
            flowLayoutButtons.Location = new Point(93, 153);
            flowLayoutButtons.Name = "flowLayoutButtons";
            flowLayoutButtons.Size = new Size(244, 82);
            flowLayoutButtons.TabIndex = 18;
            // 
            // btnDefaults
            // 
            btnDefaults.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaults.Font = new Font("Segoe UI", 8F);
            btnDefaults.Location = new Point(2, 2);
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
            btnClear.Location = new Point(98, 2);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 27);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 125);
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
            lblTitle.Location = new Point(47, 35);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(92, 32);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(92, 92);
            txtLayout.Margin = new Padding(2);
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(110, 27);
            txtLayout.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Right;
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(31, 65);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(92, 62);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(110, 27);
            txtAuthor.TabIndex = 6;
            // 
            // lblLayout
            // 
            lblLayout.Anchor = AnchorStyles.Right;
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(32, 95);
            lblLayout.Margin = new Padding(2, 0, 2, 0);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(56, 20);
            lblLayout.TabIndex = 2;
            lblLayout.Text = "Layout:";
            // 
            // dpDate
            // 
            dpDate.Dock = DockStyle.Fill;
            dpDate.Location = new Point(93, 123);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(244, 27);
            dpDate.TabIndex = 19;
            // 
            // EditorYaml
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpYaml);
            Name = "EditorYaml";
            Size = new Size(533, 268);
            grpYaml.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutYamlRight.ResumeLayout(false);
            tableLayoutYamlRight.PerformLayout();
            tableLayoutYamlLeft.ResumeLayout(false);
            tableLayoutYamlLeft.PerformLayout();
            flowLayoutButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpYaml;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutYamlLeft;
        private Label lblDate;
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtLayout;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblLayout;
        private TableLayoutPanel tableLayoutYamlRight;
        private Label lblCategs;
        private CheckedListBox chkListCategs;
        private Button btnDefaults;
        private Button btnClear;
        private FlowLayoutPanel flowLayoutButtons;
        private DateTimePicker dpDate;
    }
}
