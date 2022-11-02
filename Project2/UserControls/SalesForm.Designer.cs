
namespace Project2.UserControls
{
    partial class SalesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFilterLine = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSell = new Project2.Utils.RoundedButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlLineFinalPrice = new System.Windows.Forms.Panel();
            this.pnlLineDiscount = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlLineBrand = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlLineType = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlLineName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlLineImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnlBlank = new System.Windows.Forms.Panel();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnRefresh = new Project2.Utils.RoundedButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlLineSearch = new System.Windows.Forms.Panel();
            this.cbFilter = new FlatComboBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lvProducts = new Project2.Forms.Components.ListViewNF();
            this.lblFilter = new System.Windows.Forms.Label();
            this.imgListProduct = new System.Windows.Forms.ImageList(this.components);
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlOperation.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilterLine
            // 
            this.pnlFilterLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFilterLine.BackColor = System.Drawing.Color.Silver;
            this.pnlFilterLine.Location = new System.Drawing.Point(250, 0);
            this.pnlFilterLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFilterLine.Name = "pnlFilterLine";
            this.pnlFilterLine.Size = new System.Drawing.Size(1, 680);
            this.pnlFilterLine.TabIndex = 7;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLeft.Controls.Add(this.btnSell);
            this.pnlLeft.Controls.Add(this.lblQuantity);
            this.pnlLeft.Controls.Add(this.pnlLineFinalPrice);
            this.pnlLeft.Controls.Add(this.pnlLineDiscount);
            this.pnlLeft.Controls.Add(this.lblDiscount);
            this.pnlLeft.Controls.Add(this.pnlPrice);
            this.pnlLeft.Controls.Add(this.lblPrice);
            this.pnlLeft.Controls.Add(this.pnlLineBrand);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Controls.Add(this.pnlLineType);
            this.pnlLeft.Controls.Add(this.lblType);
            this.pnlLeft.Controls.Add(this.pnlLineName);
            this.pnlLeft.Controls.Add(this.lblName);
            this.pnlLeft.Controls.Add(this.pnlLineImage);
            this.pnlLeft.Controls.Add(this.pbImage);
            this.pnlLeft.Controls.Add(this.pnlBlank);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 630);
            this.pnlLeft.TabIndex = 8;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BorderRadius = 0;
            this.btnSell.BorderSize = 0;
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(0, 580);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(250, 50);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Sell";
            this.btnSell.TextColor = System.Drawing.Color.White;
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(0, 462);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantity.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblQuantity.Size = new System.Drawing.Size(103, 43);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineFinalPrice
            // 
            this.pnlLineFinalPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineFinalPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineFinalPrice.Location = new System.Drawing.Point(0, 461);
            this.pnlLineFinalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineFinalPrice.Name = "pnlLineFinalPrice";
            this.pnlLineFinalPrice.Size = new System.Drawing.Size(250, 1);
            this.pnlLineFinalPrice.TabIndex = 17;
            // 
            // pnlLineDiscount
            // 
            this.pnlLineDiscount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineDiscount.Location = new System.Drawing.Point(0, 460);
            this.pnlLineDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineDiscount.Name = "pnlLineDiscount";
            this.pnlLineDiscount.Size = new System.Drawing.Size(250, 1);
            this.pnlLineDiscount.TabIndex = 16;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(0, 417);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiscount.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblDiscount.Size = new System.Drawing.Size(103, 43);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPrice
            // 
            this.pnlPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrice.Location = new System.Drawing.Point(0, 416);
            this.pnlPrice.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(250, 1);
            this.pnlPrice.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(0, 373);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblPrice.Size = new System.Drawing.Size(67, 43);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineBrand
            // 
            this.pnlLineBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineBrand.Location = new System.Drawing.Point(0, 372);
            this.pnlLineBrand.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineBrand.Name = "pnlLineBrand";
            this.pnlLineBrand.Size = new System.Drawing.Size(250, 1);
            this.pnlLineBrand.TabIndex = 14;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(0, 329);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0);
            this.lblBrand.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblBrand.Size = new System.Drawing.Size(77, 43);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineType
            // 
            this.pnlLineType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineType.Location = new System.Drawing.Point(0, 328);
            this.pnlLineType.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineType.Name = "pnlLineType";
            this.pnlLineType.Size = new System.Drawing.Size(250, 1);
            this.pnlLineType.TabIndex = 13;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(0, 285);
            this.lblType.Margin = new System.Windows.Forms.Padding(5);
            this.lblType.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblType.Size = new System.Drawing.Size(66, 43);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineName
            // 
            this.pnlLineName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineName.Location = new System.Drawing.Point(0, 284);
            this.pnlLineName.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineName.Name = "pnlLineName";
            this.pnlLineName.Size = new System.Drawing.Size(250, 1);
            this.pnlLineName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 241);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.MaximumSize = new System.Drawing.Size(250, 300);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblName.Size = new System.Drawing.Size(81, 43);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineImage
            // 
            this.pnlLineImage.BackColor = System.Drawing.Color.Silver;
            this.pnlLineImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineImage.Location = new System.Drawing.Point(0, 240);
            this.pnlLineImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineImage.Name = "pnlLineImage";
            this.pnlLineImage.Size = new System.Drawing.Size(250, 1);
            this.pnlLineImage.TabIndex = 11;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.InitialImage = global::Project2.Properties.Resources.car_icon;
            this.pbImage.Location = new System.Drawing.Point(0, 40);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Padding = new System.Windows.Forms.Padding(5);
            this.pbImage.Size = new System.Drawing.Size(250, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // pnlBlank
            // 
            this.pnlBlank.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBlank.Location = new System.Drawing.Point(0, 0);
            this.pnlBlank.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBlank.Name = "pnlBlank";
            this.pnlBlank.Size = new System.Drawing.Size(250, 40);
            this.pnlBlank.TabIndex = 2;
            // 
            // pnlOperation
            // 
            this.pnlOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOperation.BackColor = System.Drawing.Color.White;
            this.pnlOperation.Controls.Add(this.btnRefresh);
            this.pnlOperation.Controls.Add(this.btnSearch);
            this.pnlOperation.Controls.Add(this.txtSearch);
            this.pnlOperation.Controls.Add(this.pnlLineSearch);
            this.pnlOperation.Controls.Add(this.cbFilter);
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(1280, 40);
            this.pnlOperation.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(161)))), ((int)(((byte)(254)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(161)))), ((int)(((byte)(254)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(161)))), ((int)(((byte)(254)))));
            this.btnRefresh.BorderRadius = 3;
            this.btnRefresh.BorderSize = 1;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Project2.Properties.Resources.refresh_icon;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(510, 7);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 25);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "        Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::Project2.Properties.Resources.search_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1235, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(18, 18);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(932, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlLineSearch
            // 
            this.pnlLineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlLineSearch.Location = new System.Drawing.Point(930, 32);
            this.pnlLineSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineSearch.Name = "pnlLineSearch";
            this.pnlLineSearch.Size = new System.Drawing.Size(325, 1);
            this.pnlLineSearch.TabIndex = 12;
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbFilter.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ItemHeight = 21;
            this.cbFilter.Location = new System.Drawing.Point(266, 6);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(240, 29);
            this.cbFilter.TabIndex = 10;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.lvProducts);
            this.pnlContainer.Controls.Add(this.lblFilter);
            this.pnlContainer.Location = new System.Drawing.Point(250, 40);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1030, 590);
            this.pnlContainer.TabIndex = 10;
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProducts.BackColor = System.Drawing.SystemColors.Control;
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(16, 45);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(0);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(997, 531);
            this.lvProducts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFilter.Location = new System.Drawing.Point(20, 20);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 29);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "All";
            // 
            // imgListProduct
            // 
            this.imgListProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListProduct.ImageSize = new System.Drawing.Size(250, 200);
            this.imgListProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlVerticalLine
            // 
            this.pnlVerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVerticalLine.BackColor = System.Drawing.Color.Silver;
            this.pnlVerticalLine.Location = new System.Drawing.Point(0, 40);
            this.pnlVerticalLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVerticalLine.Name = "pnlVerticalLine";
            this.pnlVerticalLine.Size = new System.Drawing.Size(1280, 1);
            this.pnlVerticalLine.TabIndex = 14;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlFilterLine);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlVerticalLine);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlOperation);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SalesForm";
            this.Size = new System.Drawing.Size(1280, 630);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilterLine;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlOperation;
        private FlatComboBox cbFilter;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ImageList imgListProduct;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlLineSearch;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private Utils.RoundedButton btnSell;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnlBlank;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiscount;
        private Forms.Components.ListViewNF lvProducts;
        private System.Windows.Forms.Panel pnlLineImage;
        private System.Windows.Forms.Panel pnlLineFinalPrice;
        private System.Windows.Forms.Panel pnlLineDiscount;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Panel pnlLineBrand;
        private System.Windows.Forms.Panel pnlLineType;
        private System.Windows.Forms.Panel pnlLineName;
        private Utils.RoundedButton btnRefresh;
    }
}