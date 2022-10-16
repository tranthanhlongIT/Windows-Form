
namespace Project2.UserControls
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlLineSearch = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.imgListCategory = new System.Windows.Forms.ImageList(this.components);
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.pnlFilterLine = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.chId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCategory_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefresh = new Project2.Utils.RoundedButton();
            this.btnDelete = new Project2.Utils.RoundedButton();
            this.btnUpdate = new Project2.Utils.RoundedButton();
            this.btnAdd = new Project2.Utils.RoundedButton();
            this.pnlOperation.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.White;
            this.pnlOperation.Controls.Add(this.btnRefresh);
            this.pnlOperation.Controls.Add(this.btnDelete);
            this.pnlOperation.Controls.Add(this.btnUpdate);
            this.pnlOperation.Controls.Add(this.btnAdd);
            this.pnlOperation.Controls.Add(this.btnSearch);
            this.pnlOperation.Controls.Add(this.txtSearch);
            this.pnlOperation.Controls.Add(this.pnlLineSearch);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(1280, 40);
            this.pnlOperation.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1235, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(18, 18);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSearch.Location = new System.Drawing.Point(932, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 18);
            this.txtSearch.TabIndex = 1;
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
            this.pnlLineSearch.Size = new System.Drawing.Size(325, 2);
            this.pnlLineSearch.TabIndex = 4;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLeft.Controls.Add(this.tvCategory);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 630);
            this.pnlLeft.TabIndex = 3;
            // 
            // tvCategory
            // 
            this.tvCategory.BackColor = System.Drawing.Color.White;
            this.tvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCategory.FullRowSelect = true;
            this.tvCategory.HideSelection = false;
            this.tvCategory.ImageIndex = 0;
            this.tvCategory.ImageList = this.imgListCategory;
            this.tvCategory.Indent = 20;
            this.tvCategory.ItemHeight = 25;
            this.tvCategory.Location = new System.Drawing.Point(0, 15);
            this.tvCategory.Margin = new System.Windows.Forms.Padding(30);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.SelectedImageIndex = 0;
            this.tvCategory.ShowLines = false;
            this.tvCategory.ShowRootLines = false;
            this.tvCategory.Size = new System.Drawing.Size(250, 600);
            this.tvCategory.TabIndex = 0;
            this.tvCategory.TabStop = false;
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
            // 
            // imgListCategory
            // 
            this.imgListCategory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCategory.ImageStream")));
            this.imgListCategory.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCategory.Images.SetKeyName(0, "iLogo");
            this.imgListCategory.Images.SetKeyName(1, "iSedan");
            this.imgListCategory.Images.SetKeyName(2, "iSUV");
            this.imgListCategory.Images.SetKeyName(3, "iHactchback");
            this.imgListCategory.Images.SetKeyName(4, "iSportcar");
            this.imgListCategory.Images.SetKeyName(5, "iSubaru");
            this.imgListCategory.Images.SetKeyName(6, "iToyota");
            this.imgListCategory.Images.SetKeyName(7, "iLexus");
            this.imgListCategory.Images.SetKeyName(8, "iBMW");
            this.imgListCategory.Images.SetKeyName(9, "iMercedes");
            // 
            // pnlVerticalLine
            // 
            this.pnlVerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVerticalLine.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlVerticalLine.Location = new System.Drawing.Point(0, 40);
            this.pnlVerticalLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVerticalLine.Name = "pnlVerticalLine";
            this.pnlVerticalLine.Size = new System.Drawing.Size(1280, 2);
            this.pnlVerticalLine.TabIndex = 1;
            // 
            // pnlFilterLine
            // 
            this.pnlFilterLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFilterLine.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlFilterLine.Location = new System.Drawing.Point(250, 0);
            this.pnlFilterLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFilterLine.Name = "pnlFilterLine";
            this.pnlFilterLine.Size = new System.Drawing.Size(1, 680);
            this.pnlFilterLine.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chId,
            this.chName,
            this.chPrice,
            this.chDiscount,
            this.chQuantity,
            this.chCategory_name,
            this.chAvailable,
            this.chButton});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.White;
            this.dgvProduct.Location = new System.Drawing.Point(260, 48);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(10);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 50;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1010, 572);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.TabStop = false;
            // 
            // chId
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.chId.DefaultCellStyle = dataGridViewCellStyle13;
            this.chId.FillWeight = 10F;
            this.chId.HeaderText = "ID";
            this.chId.MaxInputLength = 10;
            this.chId.MinimumWidth = 50;
            this.chId.Name = "chId";
            this.chId.ReadOnly = true;
            // 
            // chName
            // 
            this.chName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.chName.DefaultCellStyle = dataGridViewCellStyle14;
            this.chName.FillWeight = 300F;
            this.chName.HeaderText = "Name";
            this.chName.MaxInputLength = 50;
            this.chName.MinimumWidth = 200;
            this.chName.Name = "chName";
            this.chName.ReadOnly = true;
            // 
            // chPrice
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Format = "C0";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.chPrice.DefaultCellStyle = dataGridViewCellStyle15;
            this.chPrice.FillWeight = 50F;
            this.chPrice.HeaderText = "Price";
            this.chPrice.MaxInputLength = 10;
            this.chPrice.MinimumWidth = 90;
            this.chPrice.Name = "chPrice";
            this.chPrice.ReadOnly = true;
            this.chPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chDiscount
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Format = "C0";
            dataGridViewCellStyle16.NullValue = "0%";
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.chDiscount.DefaultCellStyle = dataGridViewCellStyle16;
            this.chDiscount.FillWeight = 50F;
            this.chDiscount.HeaderText = "Discount";
            this.chDiscount.MaxInputLength = 10;
            this.chDiscount.MinimumWidth = 90;
            this.chDiscount.Name = "chDiscount";
            this.chDiscount.ReadOnly = true;
            // 
            // chQuantity
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.chQuantity.DefaultCellStyle = dataGridViewCellStyle17;
            this.chQuantity.FillWeight = 50F;
            this.chQuantity.HeaderText = "Quantity";
            this.chQuantity.MaxInputLength = 10;
            this.chQuantity.MinimumWidth = 90;
            this.chQuantity.Name = "chQuantity";
            this.chQuantity.ReadOnly = true;
            // 
            // chCategory_name
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.chCategory_name.DefaultCellStyle = dataGridViewCellStyle18;
            this.chCategory_name.FillWeight = 50F;
            this.chCategory_name.HeaderText = "Brand";
            this.chCategory_name.MaxInputLength = 10;
            this.chCategory_name.MinimumWidth = 150;
            this.chCategory_name.Name = "chCategory_name";
            this.chCategory_name.ReadOnly = true;
            // 
            // chAvailable
            // 
            this.chAvailable.FillWeight = 50F;
            this.chAvailable.HeaderText = "Available";
            this.chAvailable.MaxInputLength = 1;
            this.chAvailable.MinimumWidth = 90;
            this.chAvailable.Name = "chAvailable";
            this.chAvailable.ReadOnly = true;
            // 
            // chButton
            // 
            this.chButton.FillWeight = 20F;
            this.chButton.HeaderText = "#";
            this.chButton.MinimumWidth = 20;
            this.chButton.Name = "chButton";
            this.chButton.ReadOnly = true;
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
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(526, 8);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 25);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "     Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.BorderRadius = 3;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(434, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "     Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.BorderRadius = 3;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(342, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 25);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "     Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.BorderRadius = 3;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(260, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "    Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pnlFilterLine);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlVerticalLine);
            this.Controls.Add(this.pnlOperation);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductForm";
            this.Size = new System.Drawing.Size(1280, 630);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private System.Windows.Forms.Panel pnlLineSearch;
        private System.Windows.Forms.Panel pnlFilterLine;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.ImageList imgListCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn chId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCategory_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAvailable;
        private System.Windows.Forms.DataGridViewButtonColumn chButton;
        private System.Windows.Forms.Button btnSearch;
        private Utils.RoundedButton btnAdd;
        private Utils.RoundedButton btnUpdate;
        private Utils.RoundedButton btnDelete;
        private Utils.RoundedButton btnRefresh;
    }
}
