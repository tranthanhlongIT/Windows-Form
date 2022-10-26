
namespace Project2.Forms.Components
{
    partial class CustomerModalForm
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
            this.lblRequiredPhone = new System.Windows.Forms.Label();
            this.lblRequiredLName = new System.Windows.Forms.Label();
            this.lblRequiredFName = new System.Windows.Forms.Label();
            this.lblRequiredActive = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtPhone = new Project2.Utils.FlatTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cbGender = new FlatComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbActive = new FlatComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtLName = new Project2.Utils.FlatTextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtUpdatedAt = new Project2.Utils.FlatTextBox();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.txtCreatedAt = new Project2.Utils.FlatTextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtZipcode = new Project2.Utils.FlatTextBox();
            this.txtAddress = new Project2.Utils.FlatTextBox();
            this.txtFName = new Project2.Utils.FlatTextBox();
            this.txtId = new Project2.Utils.FlatTextBox();
            this.cbCity = new FlatComboBox();
            this.btnBack = new Project2.Utils.RoundedButton();
            this.btnConfirm = new Project2.Utils.RoundedButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlContainer.SuspendLayout();
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
            this.pnlContainer.Controls.Add(this.lblRequiredPhone);
            this.pnlContainer.Controls.Add(this.lblRequiredLName);
            this.pnlContainer.Controls.Add(this.lblRequiredFName);
            this.pnlContainer.Controls.Add(this.lblRequiredActive);
            this.pnlContainer.Controls.Add(this.lblZipcode);
            this.pnlContainer.Controls.Add(this.txtPhone);
            this.pnlContainer.Controls.Add(this.lblPhone);
            this.pnlContainer.Controls.Add(this.cbGender);
            this.pnlContainer.Controls.Add(this.lblGender);
            this.pnlContainer.Controls.Add(this.cbActive);
            this.pnlContainer.Controls.Add(this.lblActive);
            this.pnlContainer.Controls.Add(this.txtLName);
            this.pnlContainer.Controls.Add(this.lblLName);
            this.pnlContainer.Controls.Add(this.txtUpdatedAt);
            this.pnlContainer.Controls.Add(this.lblUpdatedAt);
            this.pnlContainer.Controls.Add(this.txtCreatedAt);
            this.pnlContainer.Controls.Add(this.lblCreatedAt);
            this.pnlContainer.Controls.Add(this.txtZipcode);
            this.pnlContainer.Controls.Add(this.txtAddress);
            this.pnlContainer.Controls.Add(this.txtFName);
            this.pnlContainer.Controls.Add(this.txtId);
            this.pnlContainer.Controls.Add(this.cbCity);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnConfirm);
            this.pnlContainer.Controls.Add(this.lblQuantity);
            this.pnlContainer.Controls.Add(this.lblCity);
            this.pnlContainer.Controls.Add(this.lblAddress);
            this.pnlContainer.Controls.Add(this.lblFName);
            this.pnlContainer.Controls.Add(this.lblId);
            this.pnlContainer.Controls.Add(this.pnlVerticalLine);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 770);
            this.pnlContainer.TabIndex = 1;
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.AutoSize = true;
            this.lblRequiredPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPhone.Location = new System.Drawing.Point(403, 125);
            this.lblRequiredPhone.Name = "lblRequiredPhone";
            this.lblRequiredPhone.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredPhone.TabIndex = 41;
            this.lblRequiredPhone.Text = "*";
            // 
            // lblRequiredLName
            // 
            this.lblRequiredLName.AutoSize = true;
            this.lblRequiredLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredLName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredLName.Location = new System.Drawing.Point(432, 70);
            this.lblRequiredLName.Name = "lblRequiredLName";
            this.lblRequiredLName.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredLName.TabIndex = 40;
            this.lblRequiredLName.Text = "*";
            // 
            // lblRequiredFName
            // 
            this.lblRequiredFName.AutoSize = true;
            this.lblRequiredFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredFName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFName.Location = new System.Drawing.Point(85, 70);
            this.lblRequiredFName.Name = "lblRequiredFName";
            this.lblRequiredFName.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredFName.TabIndex = 39;
            this.lblRequiredFName.Text = "*";
            this.lblRequiredFName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequiredActive
            // 
            this.lblRequiredActive.AutoSize = true;
            this.lblRequiredActive.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRequiredActive.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredActive.Location = new System.Drawing.Point(405, 15);
            this.lblRequiredActive.Name = "lblRequiredActive";
            this.lblRequiredActive.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredActive.TabIndex = 38;
            this.lblRequiredActive.Text = "*";
            // 
            // lblZipcode
            // 
            this.lblZipcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblZipcode.Location = new System.Drawing.Point(352, 330);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(69, 20);
            this.lblZipcode.TabIndex = 37;
            this.lblZipcode.Text = "Zipcode";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(355, 147);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(335, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPhone.Location = new System.Drawing.Point(352, 125);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "Phone";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.BorderColor = System.Drawing.Color.DarkGray;
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(10, 147);
            this.cbGender.Margin = new System.Windows.Forms.Padding(0);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(335, 25);
            this.cbGender.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblGender.Location = new System.Drawing.Point(7, 125);
            this.lblGender.Margin = new System.Windows.Forms.Padding(0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 20);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gender";
            // 
            // cbActive
            // 
            this.cbActive.BackColor = System.Drawing.Color.White;
            this.cbActive.BorderColor = System.Drawing.Color.DarkGray;
            this.cbActive.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Location = new System.Drawing.Point(355, 37);
            this.cbActive.Margin = new System.Windows.Forms.Padding(0);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(335, 25);
            this.cbActive.TabIndex = 1;
            // 
            // lblActive
            // 
            this.lblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblActive.Location = new System.Drawing.Point(352, 15);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(58, 20);
            this.lblActive.TabIndex = 31;
            this.lblActive.Text = "Active";
            // 
            // txtLName
            // 
            this.txtLName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLName.Location = new System.Drawing.Point(355, 92);
            this.txtLName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLName.MaxLength = 50;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(335, 25);
            this.txtLName.TabIndex = 3;
            // 
            // lblLName
            // 
            this.lblLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblLName.Location = new System.Drawing.Point(352, 70);
            this.lblLName.Margin = new System.Windows.Forms.Padding(0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(85, 20);
            this.lblLName.TabIndex = 29;
            this.lblLName.Text = "Last Name";
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUpdatedAt.Enabled = false;
            this.txtUpdatedAt.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdatedAt.Location = new System.Drawing.Point(355, 407);
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
            this.lblUpdatedAt.Location = new System.Drawing.Point(352, 385);
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
            this.txtCreatedAt.Location = new System.Drawing.Point(10, 407);
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
            this.lblCreatedAt.Location = new System.Drawing.Point(7, 385);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(91, 20);
            this.lblCreatedAt.TabIndex = 0;
            this.lblCreatedAt.Text = "Created At";
            this.lblCreatedAt.Visible = false;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderColor = System.Drawing.Color.DarkGray;
            this.txtZipcode.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtZipcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtZipcode.Location = new System.Drawing.Point(355, 352);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(0);
            this.txtZipcode.MaxLength = 50;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(335, 25);
            this.txtZipcode.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(10, 202);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(680, 120);
            this.txtAddress.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFName.Location = new System.Drawing.Point(10, 92);
            this.txtFName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFName.MaxLength = 50;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(335, 25);
            this.txtFName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(10, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(335, 25);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // cbCity
            // 
            this.cbCity.BackColor = System.Drawing.Color.White;
            this.cbCity.BorderColor = System.Drawing.Color.DarkGray;
            this.cbCity.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(10, 352);
            this.cbCity.Margin = new System.Windows.Forms.Padding(0);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(335, 25);
            this.cbCity.TabIndex = 7;
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
            this.btnConfirm.Text = "    Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblQuantity.Location = new System.Drawing.Point(467, 278);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 20);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCity.Location = new System.Drawing.Point(7, 330);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 20);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblAddress.Location = new System.Drawing.Point(7, 180);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 20);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFName.Location = new System.Drawing.Point(7, 70);
            this.lblFName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(83, 20);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblId.Location = new System.Drawing.Point(7, 15);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
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
            // CustomerModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerModalForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private Utils.RoundedButton btnBack;
        private Utils.RoundedButton btnConfirm;
        private Utils.FlatTextBox txtFName;
        private Utils.FlatTextBox txtId;
        private Utils.FlatTextBox txtUpdatedAt;
        private System.Windows.Forms.Label lblUpdatedAt;
        private Utils.FlatTextBox txtCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblZipcode;
        private Utils.FlatTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private FlatComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private FlatComboBox cbActive;
        private System.Windows.Forms.Label lblActive;
        private Utils.FlatTextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private Utils.FlatTextBox txtZipcode;
        private Utils.FlatTextBox txtAddress;
        private FlatComboBox cbCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblRequiredPhone;
        private System.Windows.Forms.Label lblRequiredLName;
        private System.Windows.Forms.Label lblRequiredFName;
        private System.Windows.Forms.Label lblRequiredActive;
    }
}