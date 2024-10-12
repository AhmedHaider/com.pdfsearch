namespace com.pdfsearch
{
    partial class frmLogin
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
            lblTitlebar = new Label();
            txtDomainName = new TextBox();
            txtDomainUserName = new TextBox();
            btnClose = new Button();
            btnLogin = new Button();
            btnExit = new Button();
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
            lblTitlebar.Size = new Size(246, 26);
            lblTitlebar.TabIndex = 0;
            lblTitlebar.Text = "PDF Search";
            lblTitlebar.TextAlign = ContentAlignment.MiddleLeft;
            lblTitlebar.MouseDown += lblTitlebar_MouseDown;
            // 
            // txtDomainName
            // 
            txtDomainName.Location = new Point(15, 44);
            txtDomainName.Name = "txtDomainName";
            txtDomainName.PlaceholderText = "Domain Name";
            txtDomainName.ReadOnly = true;
            txtDomainName.Size = new Size(216, 23);
            txtDomainName.TabIndex = 2;
            // 
            // txtDomainUserName
            // 
            txtDomainUserName.Location = new Point(15, 73);
            txtDomainUserName.Name = "txtDomainUserName";
            txtDomainUserName.PlaceholderText = "Domain User Name";
            txtDomainUserName.ReadOnly = true;
            txtDomainUserName.Size = new Size(216, 23);
            txtDomainUserName.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(221, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(156, 105);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "L O G I N";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Tomato;
            btnExit.Location = new Point(15, 105);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "E X I T";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(246, 143);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(txtDomainUserName);
            Controls.Add(txtDomainName);
            Controls.Add(lblTitlebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateData;
        private Label lblTitlebar;
        private TextBox txtDomainName;
        private TextBox txtDomainUserName;
        private Button btnClose;
        private Button btnLogin;
        private Button btnExit;
    }
}
