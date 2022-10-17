﻿
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
            this.txtUpdatedAt = new Project2.Utils.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreatedAt = new Project2.Utils.FlatTextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtQuantity = new Project2.Utils.FlatTextBox();
            this.txtDiscount = new Project2.Utils.FlatTextBox();
            this.txtPrice = new Project2.Utils.FlatTextBox();
            this.txtDescription = new Project2.Utils.FlatTextBox();
            this.txtName = new Project2.Utils.FlatTextBox();
            this.txtId = new Project2.Utils.FlatTextBox();
            this.cbAvailable = new FlatComboBox();
            this.cbBrand = new FlatComboBox();
            this.cbType = new FlatComboBox();
            this.btnUploadImage = new Project2.Utils.RoundedButton();
            this.btnBack = new Project2.Utils.RoundedButton();
            this.btnConfirm = new Project2.Utils.RoundedButton();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.pnlUploadImage = new System.Windows.Forms.Panel();
            this.pbUploadImage = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlUploadImage.SuspendLayout();
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
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
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(38, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 22);
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
            this.pnlContainer.Controls.Add(this.txtUpdatedAt);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.txtCreatedAt);
            this.pnlContainer.Controls.Add(this.lblCreatedAt);
            this.pnlContainer.Controls.Add(this.txtImagePath);
            this.pnlContainer.Controls.Add(this.txtQuantity);
            this.pnlContainer.Controls.Add(this.txtDiscount);
            this.pnlContainer.Controls.Add(this.txtPrice);
            this.pnlContainer.Controls.Add(this.txtDescription);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.txtId);
            this.pnlContainer.Controls.Add(this.cbAvailable);
            this.pnlContainer.Controls.Add(this.cbBrand);
            this.pnlContainer.Controls.Add(this.cbType);
            this.pnlContainer.Controls.Add(this.btnUploadImage);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnConfirm);
            this.pnlContainer.Controls.Add(this.lblBrand);
            this.pnlContainer.Controls.Add(this.lblType);
            this.pnlContainer.Controls.Add(this.lblImage);
            this.pnlContainer.Controls.Add(this.lblAvailable);
            this.pnlContainer.Controls.Add(this.lblQuantity);
            this.pnlContainer.Controls.Add(this.lblDiscount);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.lblDescription);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.lblId);
            this.pnlContainer.Controls.Add(this.pnlVerticalLine);
            this.pnlContainer.Controls.Add(this.pnlUploadImage);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 770);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUpdatedAt.Enabled = false;
            this.txtUpdatedAt.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdatedAt.Location = new System.Drawing.Point(355, 656);
            this.txtUpdatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.Size = new System.Drawing.Size(335, 29);
            this.txtUpdatedAt.TabIndex = 47;
            this.txtUpdatedAt.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(352, 634);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Updated At";
            this.label2.Visible = false;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreatedAt.Location = new System.Drawing.Point(10, 656);
            this.txtCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(335, 29);
            this.txtCreatedAt.TabIndex = 45;
            this.txtCreatedAt.Visible = false;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCreatedAt.Location = new System.Drawing.Point(7, 634);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(115, 22);
            this.lblCreatedAt.TabIndex = 44;
            this.lblCreatedAt.Text = "Created At";
            this.lblCreatedAt.Visible = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(10, 405);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(220, 32);
            this.txtImagePath.TabIndex = 43;
            this.txtImagePath.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.Location = new System.Drawing.Point(470, 300);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(220, 29);
            this.txtQuantity.TabIndex = 42;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.Location = new System.Drawing.Point(240, 300);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(220, 29);
            this.txtDiscount.TabIndex = 41;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(10, 300);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 29);
            this.txtPrice.TabIndex = 40;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(10, 150);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(680, 120);
            this.txtDescription.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(240, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(450, 29);
            this.txtName.TabIndex = 38;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(10, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 30);
            this.txtId.TabIndex = 37;
            // 
            // cbAvailable
            // 
            this.cbAvailable.BackColor = System.Drawing.Color.White;
            this.cbAvailable.BorderColor = System.Drawing.Color.DarkGray;
            this.cbAvailable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAvailable.FormattingEnabled = true;
            this.cbAvailable.Location = new System.Drawing.Point(470, 92);
            this.cbAvailable.Margin = new System.Windows.Forms.Padding(0);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(220, 30);
            this.cbAvailable.TabIndex = 34;
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.Color.White;
            this.cbBrand.BorderColor = System.Drawing.Color.DarkGray;
            this.cbBrand.Enabled = false;
            this.cbBrand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(240, 92);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(0);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(220, 30);
            this.cbBrand.TabIndex = 33;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.BorderColor = System.Drawing.Color.DarkGray;
            this.cbType.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(10, 92);
            this.cbType.Margin = new System.Windows.Forms.Padding(0);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(220, 29);
            this.cbType.TabIndex = 32;
            this.cbType.SelectionChangeCommitted += new System.EventHandler(this.cbType_SelectionChangeCommitted);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUploadImage.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnUploadImage.BorderColor = System.Drawing.Color.Silver;
            this.btnUploadImage.BorderRadius = 4;
            this.btnUploadImage.BorderSize = 1;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadImage.Location = new System.Drawing.Point(10, 355);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(221, 35);
            this.btnUploadImage.TabIndex = 36;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
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
            this.btnConfirm.BorderRadius = 4;
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
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblBrand.Location = new System.Drawing.Point(237, 70);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(65, 22);
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
            this.lblType.Location = new System.Drawing.Point(7, 70);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 22);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // lblImage
            // 
            this.lblImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblImage.Location = new System.Drawing.Point(7, 333);
            this.lblImage.Margin = new System.Windows.Forms.Padding(0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(70, 22);
            this.lblImage.TabIndex = 27;
            this.lblImage.Text = "Image";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblAvailable.Location = new System.Drawing.Point(467, 70);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(98, 22);
            this.lblAvailable.TabIndex = 24;
            this.lblAvailable.Text = "Available";
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
            this.lblQuantity.Size = new System.Drawing.Size(92, 22);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDiscount.Location = new System.Drawing.Point(237, 278);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(89, 22);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "Discount";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPrice.Location = new System.Drawing.Point(7, 278);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescription.Location = new System.Drawing.Point(7, 128);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(111, 22);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblName.Location = new System.Drawing.Point(237, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 22);
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
            this.lblId.Size = new System.Drawing.Size(29, 22);
            this.lblId.TabIndex = 1;
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
            // pnlUploadImage
            // 
            this.pnlUploadImage.BackColor = System.Drawing.Color.Silver;
            this.pnlUploadImage.Controls.Add(this.pbUploadImage);
            this.pnlUploadImage.ForeColor = System.Drawing.Color.Silver;
            this.pnlUploadImage.Location = new System.Drawing.Point(240, 355);
            this.pnlUploadImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUploadImage.Name = "pnlUploadImage";
            this.pnlUploadImage.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUploadImage.Size = new System.Drawing.Size(370, 270);
            this.pnlUploadImage.TabIndex = 35;
            // 
            // pbUploadImage
            // 
            this.pbUploadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUploadImage.BackColor = System.Drawing.Color.White;
            this.pbUploadImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUploadImage.InitialImage")));
            this.pbUploadImage.Location = new System.Drawing.Point(1, 1);
            this.pbUploadImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbUploadImage.Name = "pbUploadImage";
            this.pbUploadImage.Padding = new System.Windows.Forms.Padding(8);
            this.pbUploadImage.Size = new System.Drawing.Size(368, 268);
            this.pbUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUploadImage.TabIndex = 26;
            this.pbUploadImage.TabStop = false;
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
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
            this.Load += new System.EventHandler(this.ModalForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlUploadImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).EndInit();
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
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbUploadImage;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private Utils.RoundedButton btnBack;
        private Utils.RoundedButton btnConfirm;
        private FlatComboBox cbType;
        private FlatComboBox cbAvailable;
        private FlatComboBox cbBrand;
        private System.Windows.Forms.Panel pnlUploadImage;
        private Utils.RoundedButton btnUploadImage;
        private Utils.FlatTextBox txtQuantity;
        private Utils.FlatTextBox txtDiscount;
        private Utils.FlatTextBox txtPrice;
        private Utils.FlatTextBox txtDescription;
        private Utils.FlatTextBox txtName;
        private Utils.FlatTextBox txtId;
        private System.Windows.Forms.TextBox txtImagePath;
        private Utils.FlatTextBox txtUpdatedAt;
        private System.Windows.Forms.Label label2;
        private Utils.FlatTextBox txtCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
    }
}