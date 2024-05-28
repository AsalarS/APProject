namespace AdminApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblLogo = new Label();
            lblEmail = new Label();
            lblPass = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(274, 79);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(540, 128);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Home Care";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(324, 256);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(325, 335);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(50, 50, 77);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(322, 274);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(406, 28);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 50, 77);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(322, 353);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(406, 28);
            txtPassword.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(13, 13, 37);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(455, 428);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(166, 50);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 24);
            ClientSize = new Size(1064, 611);
            Controls.Add(loginBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPass);
            Controls.Add(lblEmail);
            Controls.Add(lblLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private Label lblEmail;
        private Label lblPass;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button loginBtn;
        private Button btnDebugManager;
    }
}