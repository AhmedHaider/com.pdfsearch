namespace com.pdfsearch.Views
{
    partial class frmManageUser
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
            btnUpdate = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            chkIsAuthorized = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCreatedAt = new TextBox();
            label6 = new Label();
            btnClose = new Button();
            grpDataContainer = new GroupBox();
            btnCancel = new Button();
            grpDataContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Gold;
            btnUpdate.Location = new Point(310, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 26);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(95, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(265, 23);
            txtId.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(95, 52);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(265, 23);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(95, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 23);
            txtPassword.TabIndex = 7;
            // 
            // chkIsAuthorized
            // 
            chkIsAuthorized.AutoSize = true;
            chkIsAuthorized.Location = new Point(96, 144);
            chkIsAuthorized.Name = "chkIsAuthorized";
            chkIsAuthorized.Size = new Size(84, 19);
            chkIsAuthorized.TabIndex = 9;
            chkIsAuthorized.Text = "Authorized";
            chkIsAuthorized.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 86);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 146);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 4;
            label4.Text = "Authorization";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 116);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 3;
            label5.Text = "Created At";
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.BorderStyle = BorderStyle.FixedSingle;
            txtCreatedAt.Location = new Point(95, 112);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.ReadOnly = true;
            txtCreatedAt.Size = new Size(265, 23);
            txtCreatedAt.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(26, 26, 26);
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(390, 26);
            label6.TabIndex = 0;
            label6.Text = "Manage User";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.MouseDown += lblTitlebar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(361, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // grpDataContainer
            // 
            grpDataContainer.Controls.Add(txtId);
            grpDataContainer.Controls.Add(label1);
            grpDataContainer.Controls.Add(label2);
            grpDataContainer.Controls.Add(chkIsAuthorized);
            grpDataContainer.Controls.Add(label3);
            grpDataContainer.Controls.Add(txtCreatedAt);
            grpDataContainer.Controls.Add(label4);
            grpDataContainer.Controls.Add(txtPassword);
            grpDataContainer.Controls.Add(label5);
            grpDataContainer.Controls.Add(txtUserName);
            grpDataContainer.ForeColor = Color.White;
            grpDataContainer.Location = new Point(6, 31);
            grpDataContainer.Name = "grpDataContainer";
            grpDataContainer.Size = new Size(378, 178);
            grpDataContainer.TabIndex = 2;
            grpDataContainer.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Tomato;
            btnCancel.Location = new Point(6, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(390, 252);
            Controls.Add(grpDataContainer);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage User";
            Load += frmManageUser_Load;
            grpDataContainer.ResumeLayout(false);
            grpDataContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Label label1;
        private TextBox txtId;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private CheckBox chkIsAuthorized;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCreatedAt;
        private Label label6;
        private Button btnClose;
        private GroupBox grpDataContainer;
        private Button btnCancel;
    }
}