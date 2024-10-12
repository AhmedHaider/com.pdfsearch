namespace com.pdfsearch.Views
{
    partial class frmAdminValidation
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
            btnAdminLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            btnCanccel = new Button();
            SuspendLayout();
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Location = new Point(9, 64);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(150, 24);
            btnAdminLogin.TabIndex = 2;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 16);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Admin Passowrd:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(9, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnCanccel
            // 
            btnCanccel.FlatStyle = FlatStyle.Flat;
            btnCanccel.ForeColor = Color.Tomato;
            btnCanccel.Location = new Point(9, 98);
            btnCanccel.Name = "btnCanccel";
            btnCanccel.Size = new Size(150, 24);
            btnCanccel.TabIndex = 3;
            btnCanccel.Text = "Cancel";
            btnCanccel.UseVisualStyleBackColor = true;
            // 
            // frmAdminValidation
            // 
            AcceptButton = btnAdminLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            CancelButton = btnCanccel;
            ClientSize = new Size(168, 140);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(btnCanccel);
            Controls.Add(btnAdminLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminValidation";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminLogin;
        private Label label1;
        private TextBox txtPassword;
        private Button btnCanccel;
    }
}