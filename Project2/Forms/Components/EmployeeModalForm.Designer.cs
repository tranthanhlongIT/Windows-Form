
namespace Project2.Forms.Components
{
    partial class EmployeeModalForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtId = new Project2.Utils.FlatTextBox();
            this.lblRequiredGender = new System.Windows.Forms.Label();
            this.lblRequiredPhone = new System.Windows.Forms.Label();
            this.lblRequiredLName = new System.Windows.Forms.Label();
            this.lblRequiredFName = new System.Windows.Forms.Label();
            this.lblRequiredConfirmPassword = new System.Windows.Forms.Label();
            this.lblRequiredPassword = new System.Windows.Forms.Label();
            this.lblRequiredEmail = new System.Windows.Forms.Label();
            this.lblRequiredActive = new System.Windows.Forms.Label();
            this.lblRequiredRole = new System.Windows.Forms.Label();
            this.cbRole = new FlatComboBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new Project2.Utils.FlatTextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new Project2.Utils.FlatTextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new Project2.Utils.FlatTextBox();
            this.btnDefaultImage = new Project2.Utils.RoundedButton();
            this.btnUploadImage = new Project2.Utils.RoundedButton();
            this.txtAddress = new Project2.Utils.FlatTextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbUploadImage = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Project2.Utils.FlatTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new Project2.Utils.FlatTextBox();
            this.lblAccInfo = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cbActive = new FlatComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtUpdatedAt = new Project2.Utils.FlatTextBox();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.txtCreatedAt = new Project2.Utils.FlatTextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtPhone = new Project2.Utils.FlatTextBox();
            this.cbGender = new FlatComboBox();
            this.btnBack = new Project2.Utils.RoundedButton();
            this.btnConfirm = new Project2.Utils.RoundedButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pbIcon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(700, 30);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project2.Properties.Resources.close_2_icon;
            this.btnClose.Location = new System.Drawing.Point(670, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(38, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Modal Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Project2.Properties.Resources.information_icon;
            this.pbIcon.Location = new System.Drawing.Point(17, 5);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(18, 18);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.txtId);
            this.pnlContainer.Controls.Add(this.lblRequiredGender);
            this.pnlContainer.Controls.Add(this.lblRequiredPhone);
            this.pnlContainer.Controls.Add(this.lblRequiredLName);
            this.pnlContainer.Controls.Add(this.lblRequiredFName);
            this.pnlContainer.Controls.Add(this.lblRequiredConfirmPassword);
            this.pnlContainer.Controls.Add(this.lblRequiredPassword);
            this.pnlContainer.Controls.Add(this.lblRequiredEmail);
            this.pnlContainer.Controls.Add(this.lblRequiredActive);
            this.pnlContainer.Controls.Add(this.lblRequiredRole);
            this.pnlContainer.Controls.Add(this.cbRole);
            this.pnlContainer.Controls.Add(this.lblLName);
            this.pnlContainer.Controls.Add(this.txtLName);
            this.pnlContainer.Controls.Add(this.lblFName);
            this.pnlContainer.Controls.Add(this.txtFName);
            this.pnlContainer.Controls.Add(this.pnlLine2);
            this.pnlContainer.Controls.Add(this.lblEmpInfo);
            this.pnlContainer.Controls.Add(this.lblConfirmPassword);
            this.pnlContainer.Controls.Add(this.lblRole);
            this.pnlContainer.Controls.Add(this.pnlLine1);
            this.pnlContainer.Controls.Add(this.txtConfirmPassword);
            this.pnlContainer.Controls.Add(this.btnDefaultImage);
            this.pnlContainer.Controls.Add(this.btnUploadImage);
            this.pnlContainer.Controls.Add(this.txtAddress);
            this.pnlContainer.Controls.Add(this.lblAdress);
            this.pnlContainer.Controls.Add(this.lblEmail);
            this.pnlContainer.Controls.Add(this.pbUploadImage);
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.lblAccInfo);
            this.pnlContainer.Controls.Add(this.lblPhone);
            this.pnlContainer.Controls.Add(this.cbActive);
            this.pnlContainer.Controls.Add(this.lblActive);
            this.pnlContainer.Controls.Add(this.txtUpdatedAt);
            this.pnlContainer.Controls.Add(this.lblUpdatedAt);
            this.pnlContainer.Controls.Add(this.txtCreatedAt);
            this.pnlContainer.Controls.Add(this.lblCreatedAt);
            this.pnlContainer.Controls.Add(this.txtPhone);
            this.pnlContainer.Controls.Add(this.cbGender);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnConfirm);
            this.pnlContainer.Controls.Add(this.lblGender);
            this.pnlContainer.Controls.Add(this.pnlVerticalLine);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 770);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(9, 656);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(335, 25);
            this.txtId.TabIndex = 76;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // lblRequiredGender
            // 
            this.lblRequiredGender.AutoSize = true;
            this.lblRequiredGender.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredGender.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredGender.Location = new System.Drawing.Point(69, 355);
            this.lblRequiredGender.Name = "lblRequiredGender";
            this.lblRequiredGender.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredGender.TabIndex = 75;
            this.lblRequiredGender.Text = "*";
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.AutoSize = true;
            this.lblRequiredPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPhone.Location = new System.Drawing.Point(403, 355);
            this.lblRequiredPhone.Name = "lblRequiredPhone";
            this.lblRequiredPhone.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredPhone.TabIndex = 74;
            this.lblRequiredPhone.Text = "*";
            // 
            // lblRequiredLName
            // 
            this.lblRequiredLName.AutoSize = true;
            this.lblRequiredLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredLName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredLName.Location = new System.Drawing.Point(433, 297);
            this.lblRequiredLName.Name = "lblRequiredLName";
            this.lblRequiredLName.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredLName.TabIndex = 72;
            this.lblRequiredLName.Text = "*";
            // 
            // lblRequiredFName
            // 
            this.lblRequiredFName.AutoSize = true;
            this.lblRequiredFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredFName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFName.Location = new System.Drawing.Point(84, 297);
            this.lblRequiredFName.Name = "lblRequiredFName";
            this.lblRequiredFName.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredFName.TabIndex = 71;
            this.lblRequiredFName.Text = "*";
            // 
            // lblRequiredConfirmPassword
            // 
            this.lblRequiredConfirmPassword.AutoSize = true;
            this.lblRequiredConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredConfirmPassword.Location = new System.Drawing.Point(406, 206);
            this.lblRequiredConfirmPassword.Name = "lblRequiredConfirmPassword";
            this.lblRequiredConfirmPassword.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredConfirmPassword.TabIndex = 70;
            this.lblRequiredConfirmPassword.Text = "*";
            // 
            // lblRequiredPassword
            // 
            this.lblRequiredPassword.AutoSize = true;
            this.lblRequiredPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredPassword.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPassword.Location = new System.Drawing.Point(345, 148);
            this.lblRequiredPassword.Name = "lblRequiredPassword";
            this.lblRequiredPassword.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredPassword.TabIndex = 69;
            this.lblRequiredPassword.Text = "*";
            // 
            // lblRequiredEmail
            // 
            this.lblRequiredEmail.AutoSize = true;
            this.lblRequiredEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredEmail.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredEmail.Location = new System.Drawing.Point(313, 91);
            this.lblRequiredEmail.Name = "lblRequiredEmail";
            this.lblRequiredEmail.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEmail.TabIndex = 68;
            this.lblRequiredEmail.Text = "*";
            // 
            // lblRequiredActive
            // 
            this.lblRequiredActive.AutoSize = true;
            this.lblRequiredActive.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredActive.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredActive.Location = new System.Drawing.Point(542, 35);
            this.lblRequiredActive.Name = "lblRequiredActive";
            this.lblRequiredActive.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredActive.TabIndex = 67;
            this.lblRequiredActive.Text = "*";
            // 
            // lblRequiredRole
            // 
            this.lblRequiredRole.AutoSize = true;
            this.lblRequiredRole.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredRole.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredRole.Location = new System.Drawing.Point(307, 35);
            this.lblRequiredRole.Name = "lblRequiredRole";
            this.lblRequiredRole.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredRole.TabIndex = 39;
            this.lblRequiredRole.Text = "*";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.White;
            this.cbRole.BorderColor = System.Drawing.Color.DarkGray;
            this.cbRole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(277, 57);
            this.cbRole.Margin = new System.Windows.Forms.Padding(0);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(212, 25);
            this.cbRole.TabIndex = 1;
            // 
            // lblLName
            // 
            this.lblLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblLName.Location = new System.Drawing.Point(353, 297);
            this.lblLName.Margin = new System.Windows.Forms.Padding(0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(85, 20);
            this.lblLName.TabIndex = 65;
            this.lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLName.Location = new System.Drawing.Point(356, 319);
            this.txtLName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLName.MaxLength = 50;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(335, 25);
            this.txtLName.TabIndex = 7;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFName.Location = new System.Drawing.Point(7, 297);
            this.lblFName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(83, 20);
            this.lblFName.TabIndex = 63;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFName.Location = new System.Drawing.Point(10, 319);
            this.txtFName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFName.MaxLength = 50;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(335, 25);
            this.txtFName.TabIndex = 6;
            // 
            // pnlLine2
            // 
            this.pnlLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.pnlLine2.Location = new System.Drawing.Point(11, 287);
            this.pnlLine2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(678, 3);
            this.pnlLine2.TabIndex = 61;
            // 
            // lblEmpInfo
            // 
            this.lblEmpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpInfo.AutoSize = true;
            this.lblEmpInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.lblEmpInfo.Location = new System.Drawing.Point(9, 267);
            this.lblEmpInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(170, 18);
            this.lblEmpInfo.TabIndex = 60;
            this.lblEmpInfo.Text = "Employee Information";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(271, 206);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(140, 20);
            this.lblConfirmPassword.TabIndex = 59;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRole.Location = new System.Drawing.Point(271, 35);
            this.lblRole.Margin = new System.Windows.Forms.Padding(0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 20);
            this.lblRole.TabIndex = 58;
            this.lblRole.Text = "Role";
            // 
            // pnlLine1
            // 
            this.pnlLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.pnlLine1.Location = new System.Drawing.Point(12, 25);
            this.pnlLine1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(678, 3);
            this.pnlLine1.TabIndex = 57;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(276, 228);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(415, 25);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // btnDefaultImage
            // 
            this.btnDefaultImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDefaultImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDefaultImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDefaultImage.BorderRadius = 3;
            this.btnDefaultImage.BorderSize = 1;
            this.btnDefaultImage.FlatAppearance.BorderSize = 0;
            this.btnDefaultImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnDefaultImage.ForeColor = System.Drawing.Color.White;
            this.btnDefaultImage.Image = global::Project2.Properties.Resources.default_image_icon;
            this.btnDefaultImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefaultImage.Location = new System.Drawing.Point(138, 227);
            this.btnDefaultImage.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDefaultImage.Name = "btnDefaultImage";
            this.btnDefaultImage.Size = new System.Drawing.Size(90, 25);
            this.btnDefaultImage.TabIndex = 54;
            this.btnDefaultImage.Text = "        Default";
            this.btnDefaultImage.TextColor = System.Drawing.Color.White;
            this.btnDefaultImage.UseVisualStyleBackColor = false;
            this.btnDefaultImage.Click += new System.EventHandler(this.btnDefaultImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnUploadImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnUploadImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnUploadImage.BorderRadius = 3;
            this.btnUploadImage.BorderSize = 1;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Image = global::Project2.Properties.Resources.upload_image_icon;
            this.btnUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadImage.Location = new System.Drawing.Point(44, 227);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(90, 25);
            this.btnUploadImage.TabIndex = 53;
            this.btnUploadImage.Text = "        Upload Image";
            this.btnUploadImage.TextColor = System.Drawing.Color.White;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(9, 435);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(680, 120);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblAdress.Location = new System.Drawing.Point(7, 413);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(67, 20);
            this.lblAdress.TabIndex = 52;
            this.lblAdress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEmail.Location = new System.Drawing.Point(271, 91);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email";
            // 
            // pbUploadImage
            // 
            this.pbUploadImage.Image = global::Project2.Properties.Resources.user_icon_default;
            this.pbUploadImage.InitialImage = global::Project2.Properties.Resources.user_icon_default;
            this.pbUploadImage.Location = new System.Drawing.Point(10, 37);
            this.pbUploadImage.Name = "pbUploadImage";
            this.pbUploadImage.Size = new System.Drawing.Size(250, 180);
            this.pbUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUploadImage.TabIndex = 46;
            this.pbUploadImage.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(276, 170);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(415, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPassword.Location = new System.Drawing.Point(271, 148);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 20);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(276, 113);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblAccInfo
            // 
            this.lblAccInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccInfo.AutoSize = true;
            this.lblAccInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.lblAccInfo.Location = new System.Drawing.Point(10, 5);
            this.lblAccInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccInfo.Name = "lblAccInfo";
            this.lblAccInfo.Size = new System.Drawing.Size(158, 18);
            this.lblAccInfo.TabIndex = 42;
            this.lblAccInfo.Text = "Account Information";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPhone.Location = new System.Drawing.Point(352, 355);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 37;
            this.lblPhone.Text = "Phone";
            // 
            // cbActive
            // 
            this.cbActive.BackColor = System.Drawing.Color.White;
            this.cbActive.BorderColor = System.Drawing.Color.DarkGray;
            this.cbActive.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Location = new System.Drawing.Point(492, 57);
            this.cbActive.Margin = new System.Windows.Forms.Padding(0);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(199, 25);
            this.cbActive.TabIndex = 2;
            // 
            // lblActive
            // 
            this.lblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblActive.Location = new System.Drawing.Point(489, 35);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(58, 20);
            this.lblActive.TabIndex = 31;
            this.lblActive.Text = "Active";
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUpdatedAt.Enabled = false;
            this.txtUpdatedAt.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdatedAt.Location = new System.Drawing.Point(355, 587);
            this.txtUpdatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.txtUpdatedAt.MaxLength = 50;
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.Size = new System.Drawing.Size(335, 25);
            this.txtUpdatedAt.TabIndex = 0;
            this.txtUpdatedAt.TabStop = false;
            this.txtUpdatedAt.Visible = false;
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblUpdatedAt.Location = new System.Drawing.Point(352, 565);
            this.lblUpdatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(95, 20);
            this.lblUpdatedAt.TabIndex = 0;
            this.lblUpdatedAt.Text = "Updated At";
            this.lblUpdatedAt.Visible = false;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreatedAt.Location = new System.Drawing.Point(10, 587);
            this.txtCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(335, 25);
            this.txtCreatedAt.TabIndex = 0;
            this.txtCreatedAt.TabStop = false;
            this.txtCreatedAt.Visible = false;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCreatedAt.Location = new System.Drawing.Point(7, 565);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(91, 20);
            this.lblCreatedAt.TabIndex = 0;
            this.lblCreatedAt.Text = "Created At";
            this.lblCreatedAt.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(355, 377);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(335, 25);
            this.txtPhone.TabIndex = 9;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.BorderColor = System.Drawing.Color.DarkGray;
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(10, 377);
            this.cbGender.Margin = new System.Windows.Forms.Padding(0);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(335, 25);
            this.cbGender.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BorderRadius = 4;
            this.btnBack.BorderSize = 1;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::Project2.Properties.Resources.back_icon;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(601, 730);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 11;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "      Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BorderRadius = 4;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = global::Project2.Properties.Resources.confirm_icon;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(491, 730);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "    Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblGender.Location = new System.Drawing.Point(7, 355);
            this.lblGender.Margin = new System.Windows.Forms.Padding(0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // pnlVerticalLine
            // 
            this.pnlVerticalLine.BackColor = System.Drawing.Color.Silver;
            this.pnlVerticalLine.Location = new System.Drawing.Point(0, 720);
            this.pnlVerticalLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVerticalLine.Name = "pnlVerticalLine";
            this.pnlVerticalLine.Size = new System.Drawing.Size(700, 1);
            this.pnlVerticalLine.TabIndex = 28;
            // 
            // EmployeeModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeeModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EmployeeModalForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private Utils.RoundedButton btnBack;
        private Utils.RoundedButton btnConfirm;
        private Utils.FlatTextBox txtUpdatedAt;
        private System.Windows.Forms.Label lblUpdatedAt;
        private Utils.FlatTextBox txtCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblPhone;
        private FlatComboBox cbActive;
        private System.Windows.Forms.Label lblActive;
        private Utils.FlatTextBox txtPhone;
        private FlatComboBox cbGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pbUploadImage;
        private Utils.FlatTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Utils.FlatTextBox txtEmail;
        private System.Windows.Forms.Label lblAccInfo;
        private Utils.FlatTextBox txtAddress;
        private System.Windows.Forms.Label lblAdress;
        private Utils.FlatTextBox txtConfirmPassword;
        private Utils.RoundedButton btnDefaultImage;
        private Utils.RoundedButton btnUploadImage;
        private System.Windows.Forms.Label lblLName;
        private Utils.FlatTextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private Utils.FlatTextBox txtFName;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Label lblEmpInfo;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlLine1;
        private FlatComboBox cbRole;
        private System.Windows.Forms.Label lblRequiredRole;
        private System.Windows.Forms.Label lblRequiredActive;
        private System.Windows.Forms.Label lblRequiredPhone;
        private System.Windows.Forms.Label lblRequiredLName;
        private System.Windows.Forms.Label lblRequiredFName;
        private System.Windows.Forms.Label lblRequiredConfirmPassword;
        private System.Windows.Forms.Label lblRequiredPassword;
        private System.Windows.Forms.Label lblRequiredEmail;
        private System.Windows.Forms.Label lblRequiredGender;
        private Utils.FlatTextBox txtId;
    }
}