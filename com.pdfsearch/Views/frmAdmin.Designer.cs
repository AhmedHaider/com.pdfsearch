namespace com.pdfsearch.Views
{
    partial class frmAdmin
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
            lblTitlebar = new Label();
            btnClose = new Button();
            dgvMain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // lblTitlebar
            // 
            lblTitlebar.BackColor = Color.FromArgb(26, 26, 26);
            lblTitlebar.Dock = DockStyle.Top;
            lblTitlebar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlebar.ForeColor = Color.White;
            lblTitlebar.Location = new Point(0, 0);
            lblTitlebar.Name = "lblTitlebar";
            lblTitlebar.Size = new Size(800, 26);
            lblTitlebar.TabIndex = 0;
            lblTitlebar.Text = "Admin";
            lblTitlebar.TextAlign = ContentAlignment.MiddleLeft;
            lblTitlebar.MouseDown += lblTitlebar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(776, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMain
            // 
            dgvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(12, 88);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(776, 350);
            dgvMain.TabIndex = 2;
            dgvMain.DoubleClick += dgvMain_DoubleClick;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMain);
            Controls.Add(btnClose);
            Controls.Add(lblTitlebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitlebar;
        private Button btnClose;
        private DataGridView dgvMain;
    }
}