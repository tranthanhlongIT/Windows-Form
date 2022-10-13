
namespace Project2
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblSignUpToSMS = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblAlreadyHaveAccount = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblBackToLogin = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignUpToSMS
            // 
            this.lblSignUpToSMS.AutoSize = true;
            this.lblSignUpToSMS.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpToSMS.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSignUpToSMS.Location = new System.Drawing.Point(100, 90);
            this.lblSignUpToSMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpToSMS.Name = "lblSignUpToSMS";
            this.lblSignUpToSMS.Size = new System.Drawing.Size(213, 33);
            this.lblSignUpToSMS.TabIndex = 0;
            this.lblSignUpToSMS.Text = "Sign up to SMS";
            this.lblSignUpToSMS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(360, 60);
            this.pnlTop.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(315, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(10, -5);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(70, 70);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtUsername.Location = new System.Drawing.Point(35, 170);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(295, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(30, 145);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 28);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowPassword.Location = new System.Drawing.Point(200, 405);
            this.chbShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(156, 32);
            this.chbShowPassword.TabIndex = 5;
            this.chbShowPassword.Text = "Show Pasword";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(35, 450);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(295, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblAlreadyHaveAccount
            // 
            this.lblAlreadyHaveAccount.AutoSize = true;
            this.lblAlreadyHaveAccount.Enabled = false;
            this.lblAlreadyHaveAccount.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlreadyHaveAccount.Location = new System.Drawing.Point(85, 500);
            this.lblAlreadyHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlreadyHaveAccount.Name = "lblAlreadyHaveAccount";
            this.lblAlreadyHaveAccount.Size = new System.Drawing.Size(237, 25);
            this.lblAlreadyHaveAccount.TabIndex = 10;
            this.lblAlreadyHaveAccount.Text = "Already have an account?";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 210);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtEmail.Location = new System.Drawing.Point(35, 235);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(30, 275);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtPassword.Location = new System.Drawing.Point(35, 300);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(295, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 340);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(172, 28);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(35, 365);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(295, 30);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBackToLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBackToLogin.Location = new System.Drawing.Point(125, 535);
            this.lblBackToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(134, 25);
            this.lblBackToLogin.TabIndex = 7;
            this.lblBackToLogin.Text = "Back to Login";
            this.lblBackToLogin.Click += new System.EventHandler(this.lbBackToLogin_Click);
            this.lblBackToLogin.MouseEnter += new System.EventHandler(this.lbBackToLogin_MouseEnter);
            this.lblBackToLogin.MouseLeave += new System.EventHandler(this.lbBackToLogin_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblBackToLogin);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAlreadyHaveAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chbShowPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSignUpToSMS);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignUpToSMS;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblAlreadyHaveAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblBackToLogin;
        private System.Windows.Forms.Button btnClose;
    }
}

