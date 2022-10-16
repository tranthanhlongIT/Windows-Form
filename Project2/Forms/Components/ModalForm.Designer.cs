
namespace Project2.Forms.Components
{
    partial class ModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBack = new Project2.Utils.RoundedButton();
            this.btnConfirm = new Project2.Utils.RoundedButton();
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.lblImage = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cbAvailable = new Project2.Utils.RoundedComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtQuantity = new Project2.Utils.RoundedTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDiscount = new Project2.Utils.RoundedTextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtPrice = new Project2.Utils.RoundedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new Project2.Utils.RoundedTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new Project2.Utils.RoundedTextBox();
            this.cbBrand = new Project2.Utils.RoundedComboBox();
            this.cbType = new Project2.Utils.RoundedComboBox();
            this.txtId = new Project2.Utils.RoundedTextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(670, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(38, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Modal Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
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
            this.pnlContainer.Controls.Add(this.btnUpload);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnConfirm);
            this.pnlContainer.Controls.Add(this.pnlVerticalLine);
            this.pnlContainer.Controls.Add(this.lblImage);
            this.pnlContainer.Controls.Add(this.pbImage);
            this.pnlContainer.Controls.Add(this.cbAvailable);
            this.pnlContainer.Controls.Add(this.lblAvailable);
            this.pnlContainer.Controls.Add(this.txtQuantity);
            this.pnlContainer.Controls.Add(this.lblQuantity);
            this.pnlContainer.Controls.Add(this.txtDiscount);
            this.pnlContainer.Controls.Add(this.lblDiscount);
            this.pnlContainer.Controls.Add(this.txtPrice);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.txtDescription);
            this.pnlContainer.Controls.Add(this.lblDescription);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.cbBrand);
            this.pnlContainer.Controls.Add(this.cbType);
            this.pnlContainer.Controls.Add(this.txtId);
            this.pnlContainer.Controls.Add(this.lblBrand);
            this.pnlContainer.Controls.Add(this.lblType);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.lblId);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 770);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnUpload.Location = new System.Drawing.Point(9, 441);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(213, 32);
            this.btnUpload.TabIndex = 31;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBack.BorderRadius = 3;
            this.btnBack.BorderSize = 1;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(601, 730);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "      Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BorderRadius = 3;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(491, 730);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 29;
            this.btnConfirm.Text = "    Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
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
            // lblImage
            // 
            this.lblImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblImage.Location = new System.Drawing.Point(9, 418);
            this.lblImage.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(46, 20);
            this.lblImage.TabIndex = 27;
            this.lblImage.Text = "Price";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbImage.InitialImage")));
            this.pbImage.Location = new System.Drawing.Point(240, 441);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(449, 276);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 26;
            this.pbImage.TabStop = false;
            // 
            // cbAvailable
            // 
            this.cbAvailable.BackColor = System.Drawing.Color.White;
            this.cbAvailable.BorderColor = System.Drawing.Color.DarkGray;
            this.cbAvailable.BorderSize = 1;
            this.cbAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAvailable.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbAvailable.ForeColor = System.Drawing.Color.DimGray;
            this.cbAvailable.IconColor = System.Drawing.Color.DarkGray;
            this.cbAvailable.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbAvailable.ListTextColor = System.Drawing.Color.DimGray;
            this.cbAvailable.Location = new System.Drawing.Point(469, 106);
            this.cbAvailable.Margin = new System.Windows.Forms.Padding(10, 0, 9, 0);
            this.cbAvailable.MinimumSize = new System.Drawing.Size(220, 30);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Padding = new System.Windows.Forms.Padding(1);
            this.cbAvailable.Size = new System.Drawing.Size(220, 34);
            this.cbAvailable.TabIndex = 25;
            this.cbAvailable.Texts = "";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblAvailable.Location = new System.Drawing.Point(466, 82);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(79, 20);
            this.lblAvailable.TabIndex = 24;
            this.lblAvailable.Text = "Available";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderRadius = 3;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.Location = new System.Drawing.Point(469, 374);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(220, 35);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblQuantity.Location = new System.Drawing.Point(466, 351);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 20);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiscount.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDiscount.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtDiscount.BorderRadius = 3;
            this.txtDiscount.BorderSize = 1;
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.Location = new System.Drawing.Point(239, 374);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtDiscount.Multiline = false;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiscount.PasswordChar = false;
            this.txtDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.Size = new System.Drawing.Size(220, 35);
            this.txtDiscount.TabIndex = 21;
            this.txtDiscount.Texts = "";
            this.txtDiscount.UnderlinedStyle = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDiscount.Location = new System.Drawing.Point(236, 351);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "Discount";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtPrice.BorderRadius = 3;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(9, 374);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(220, 35);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPrice.Location = new System.Drawing.Point(7, 351);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 20);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 3;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(9, 172);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(679, 170);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescription.Location = new System.Drawing.Point(7, 149);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 20);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtName.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtName.BorderRadius = 3;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(9, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(450, 35);
            this.txtName.TabIndex = 15;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.Color.White;
            this.cbBrand.BorderColor = System.Drawing.Color.DarkGray;
            this.cbBrand.BorderSize = 1;
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbBrand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbBrand.ForeColor = System.Drawing.Color.DimGray;
            this.cbBrand.IconColor = System.Drawing.Color.DarkGray;
            this.cbBrand.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbBrand.ListTextColor = System.Drawing.Color.DimGray;
            this.cbBrand.Location = new System.Drawing.Point(469, 39);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(10, 0, 9, 0);
            this.cbBrand.MinimumSize = new System.Drawing.Size(220, 30);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Padding = new System.Windows.Forms.Padding(1);
            this.cbBrand.Size = new System.Drawing.Size(220, 34);
            this.cbBrand.TabIndex = 14;
            this.cbBrand.Texts = "";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.BorderColor = System.Drawing.Color.DarkGray;
            this.cbType.BorderSize = 1;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbType.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbType.IconColor = System.Drawing.Color.DarkGray;
            this.cbType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbType.ListTextColor = System.Drawing.Color.DimGray;
            this.cbType.Location = new System.Drawing.Point(239, 39);
            this.cbType.Margin = new System.Windows.Forms.Padding(0);
            this.cbType.MinimumSize = new System.Drawing.Size(220, 30);
            this.cbType.Name = "cbType";
            this.cbType.Padding = new System.Windows.Forms.Padding(1);
            this.cbType.Size = new System.Drawing.Size(220, 34);
            this.cbType.TabIndex = 13;
            this.cbType.Texts = "";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtId.BorderRadius = 3;
            this.txtId.BorderSize = 1;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(9, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(9, 0, 10, 0);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(220, 35);
            this.txtId.TabIndex = 12;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblBrand.Location = new System.Drawing.Point(466, 15);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 20);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Brand";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblType.Location = new System.Drawing.Point(236, 15);
            this.lblType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 20);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblName.Location = new System.Drawing.Point(7, 82);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblId.Location = new System.Drawing.Point(7, 15);
            this.lblId.Margin = new System.Windows.Forms.Padding(0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalForm";
            this.TopMost = true;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private Utils.RoundedTextBox txtId;
        private Utils.RoundedComboBox cbBrand;
        private Utils.RoundedComboBox cbType;
        private Utils.RoundedTextBox txtName;
        private Utils.RoundedTextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private Utils.RoundedTextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private Utils.RoundedTextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private Utils.RoundedTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbImage;
        private Utils.RoundedComboBox cbAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private Utils.RoundedButton btnBack;
        private Utils.RoundedButton btnConfirm;
        private System.Windows.Forms.Button btnUpload;
    }
}