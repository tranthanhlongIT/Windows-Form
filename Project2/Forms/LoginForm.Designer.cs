
namespace Project2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDontHaveAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTop.TabIndex = 20;
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
            this.btnClose.TabIndex = 1;
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(100, 135);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(212, 33);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Login into SMS";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreateAccount.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCreateAccount.Location = new System.Drawing.Point(125, 477);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(148, 25);
            this.lblCreateAccount.TabIndex = 32;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.Click += new System.EventHandler(this.lbCreateAccount_Click);
            this.lblCreateAccount.MouseEnter += new System.EventHandler(this.lbCreateAccount_MouseEnter);
            this.lblCreateAccount.MouseLeave += new System.EventHandler(this.lbCreateAccount_MouseLeave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(30, 255);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtPassword.Location = new System.Drawing.Point(35, 280);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(295, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblDontHaveAccount
            // 
            this.lblDontHaveAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDontHaveAccount.AutoSize = true;
            this.lblDontHaveAccount.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDontHaveAccount.Location = new System.Drawing.Point(100, 442);
            this.lblDontHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDontHaveAccount.Name = "lblDontHaveAccount";
            this.lblDontHaveAccount.Size = new System.Drawing.Size(214, 25);
            this.lblDontHaveAccount.TabIndex = 25;
            this.lblDontHaveAccount.Text = "Dont have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(35, 392);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(295, 40);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 185);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.txtEmail.Location = new System.Drawing.Point(35, 210);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 30);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowPassword.Location = new System.Drawing.Point(200, 320);
            this.chbShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(156, 32);
            this.chbShowPassword.TabIndex = 23;
            this.chbShowPassword.Text = "Show Pasword";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDontHaveAccount);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chbShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDontHaveAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chbShowPassword;
    }
}