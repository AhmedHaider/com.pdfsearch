namespace com.pdfsearch
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitlebar = new Label();
            btnClose = new Button();
            txtPdfDirPath = new TextBox();
            btnBrowse = new Button();
            rdoFileName = new RadioButton();
            rdoContent = new RadioButton();
            txtSearchTerm = new TextBox();
            btnSearch = new Button();
            lstResults = new ListBox();
            ctxRightClick = new ContextMenuStrip(components);
            miOpen = new ToolStripMenuItem();
            miSeparator1 = new ToolStripSeparator();
            miSave = new ToolStripMenuItem();
            pbSpinner = new PictureBox();
            lblResultCount = new Label();
            pbAdmin = new PictureBox();
            ctxRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblTitlebar
            // 
            lblTitlebar.BackColor = Color.FromArgb(26, 26, 26);
            lblTitlebar.Dock = DockStyle.Top;
            lblTitlebar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlebar.Location = new Point(0, 0);
            lblTitlebar.Name = "lblTitlebar";
            lblTitlebar.Size = new Size(589, 26);
            lblTitlebar.TabIndex = 0;
            lblTitlebar.Text = "PDF Search";
            lblTitlebar.TextAlign = ContentAlignment.MiddleLeft;
            lblTitlebar.MouseDown += lblTitlebar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(564, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // txtPdfDirPath
            // 
            txtPdfDirPath.BorderStyle = BorderStyle.FixedSingle;
            txtPdfDirPath.Location = new Point(12, 46);
            txtPdfDirPath.Name = "txtPdfDirPath";
            txtPdfDirPath.PlaceholderText = "Select a directory...";
            txtPdfDirPath.ReadOnly = true;
            txtPdfDirPath.Size = new Size(526, 23);
            txtPdfDirPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(539, 46);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(37, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = ". . .";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // rdoFileName
            // 
            rdoFileName.AutoSize = true;
            rdoFileName.Checked = true;
            rdoFileName.Location = new Point(12, 92);
            rdoFileName.Name = "rdoFileName";
            rdoFileName.Size = new Size(78, 19);
            rdoFileName.TabIndex = 4;
            rdoFileName.TabStop = true;
            rdoFileName.Text = "File Name";
            rdoFileName.UseVisualStyleBackColor = true;
            // 
            // rdoContent
            // 
            rdoContent.AutoSize = true;
            rdoContent.Location = new Point(96, 92);
            rdoContent.Name = "rdoContent";
            rdoContent.Size = new Size(68, 19);
            rdoContent.TabIndex = 5;
            rdoContent.Text = "Content";
            rdoContent.UseVisualStyleBackColor = true;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTerm.Location = new Point(12, 117);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.PlaceholderText = "Type a search term...";
            txtSearchTerm.Size = new Size(526, 23);
            txtSearchTerm.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(539, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 23);
            btnSearch.TabIndex = 7;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstResults
            // 
            lstResults.ContextMenuStrip = ctxRightClick;
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(12, 167);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(526, 244);
            lstResults.TabIndex = 8;
            lstResults.DoubleClick += lstResults_DoubleClick;
            lstResults.KeyDown += lstResults_KeyDown;
            lstResults.MouseDown += lstResults_MouseDown;
            // 
            // ctxRightClick
            // 
            ctxRightClick.Items.AddRange(new ToolStripItem[] { miOpen, miSeparator1, miSave });
            ctxRightClick.Name = "ctxRightClick";
            ctxRightClick.Size = new Size(105, 54);
            // 
            // miOpen
            // 
            miOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            miOpen.Image = Properties.Resources.adobe_acrobat_reader_480px;
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(104, 22);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miSeparator1
            // 
            miSeparator1.Name = "miSeparator1";
            miSeparator1.Size = new Size(101, 6);
            // 
            // miSave
            // 
            miSave.Image = Properties.Resources.save_480px;
            miSave.Name = "miSave";
            miSave.Size = new Size(104, 22);
            miSave.Text = "Save";
            miSave.Click += miSave_Click;
            // 
            // pbSpinner
            // 
            pbSpinner.Image = Properties.Resources.progress_spinner_dark;
            pbSpinner.Location = new Point(539, 167);
            pbSpinner.Name = "pbSpinner";
            pbSpinner.Size = new Size(23, 23);
            pbSpinner.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpinner.TabIndex = 9;
            pbSpinner.TabStop = false;
            pbSpinner.Visible = false;
            // 
            // lblResultCount
            // 
            lblResultCount.BorderStyle = BorderStyle.FixedSingle;
            lblResultCount.Dock = DockStyle.Bottom;
            lblResultCount.Location = new Point(0, 427);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(589, 23);
            lblResultCount.TabIndex = 10;
            lblResultCount.Text = "No. of Files Found:";
            lblResultCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbAdmin
            // 
            pbAdmin.Image = Properties.Resources.administrative_tools_480px;
            pbAdmin.Location = new Point(538, 1);
            pbAdmin.Name = "pbAdmin";
            pbAdmin.Size = new Size(24, 24);
            pbAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdmin.TabIndex = 12;
            pbAdmin.TabStop = false;
            pbAdmin.Click += pbAdmin_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(589, 450);
            Controls.Add(pbAdmin);
            Controls.Add(lblResultCount);
            Controls.Add(pbSpinner);
            Controls.Add(lstResults);
            Controls.Add(rdoContent);
            Controls.Add(rdoFileName);
            Controls.Add(btnSearch);
            Controls.Add(btnBrowse);
            Controls.Add(txtSearchTerm);
            Controls.Add(txtPdfDirPath);
            Controls.Add(btnClose);
            Controls.Add(lblTitlebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ctxRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitlebar;
        private Button btnClose;
        private TextBox txtPdfDirPath;
        private Button btnBrowse;
        private RadioButton rdoFileName;
        private RadioButton rdoContent;
        private TextBox txtSearchTerm;
        private Button btnSearch;
        private ListBox lstResults;
        private PictureBox pbSpinner;
        private Label lblResultCount;
        private ContextMenuStrip ctxRightClick;
        private ToolStripMenuItem miOpen;
        private ToolStripSeparator miSeparator1;
        private ToolStripMenuItem miSave;
        private PictureBox pbAdmin;
    }
}