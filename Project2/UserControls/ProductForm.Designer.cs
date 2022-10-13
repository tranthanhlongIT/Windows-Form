
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lineSearch = new System.Windows.Forms.Panel();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.navLine = new System.Windows.Forms.Panel();
            this.filterLine = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.longtt_ptpmudDataSet = new Project2.longtt_ptpmudDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project2.longtt_ptpmudDataSetTableAdapters.ProductsTableAdapter();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longtt_ptpmudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lineSearch);
            this.pnlSearch.Controls.Add(this.pbxSearch);
            this.pnlSearch.Controls.Add(this.lblCategory);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cbCategory);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1280, 60);
            this.pnlSearch.TabIndex = 0;
            // 
            // lineSearch
            // 
            this.lineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSearch.BackColor = System.Drawing.Color.Silver;
            this.lineSearch.Location = new System.Drawing.Point(930, 43);
            this.lineSearch.Name = "lineSearch";
            this.lineSearch.Size = new System.Drawing.Size(325, 2);
            this.lineSearch.TabIndex = 4;
            // 
            // pbxSearch
            // 
            this.pbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(1230, 15);
            this.pbxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(25, 25);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 3;
            this.pbxSearch.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(95, 18);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(120, 22);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "CATEGORY:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSearch.Location = new System.Drawing.Point(930, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownHeight = 105;
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.IntegralHeight = false;
            this.cbCategory.ItemHeight = 21;
            this.cbCategory.Location = new System.Drawing.Point(200, 15);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(260, 29);
            this.cbCategory.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLeft.Controls.Add(this.tvCategory);
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(190, 570);
            this.pnlLeft.TabIndex = 3;
            // 
            // navLine
            // 
            this.navLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navLine.BackColor = System.Drawing.Color.SteelBlue;
            this.navLine.Location = new System.Drawing.Point(0, 60);
            this.navLine.Margin = new System.Windows.Forms.Padding(5);
            this.navLine.Name = "navLine";
            this.navLine.Size = new System.Drawing.Size(1280, 2);
            this.navLine.TabIndex = 1;
            // 
            // filterLine
            // 
            this.filterLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filterLine.BackColor = System.Drawing.Color.SteelBlue;
            this.filterLine.Location = new System.Drawing.Point(190, 0);
            this.filterLine.Margin = new System.Windows.Forms.Padding(0);
            this.filterLine.Name = "filterLine";
            this.filterLine.Size = new System.Drawing.Size(2, 680);
            this.filterLine.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(151)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.White;
            this.dgvProduct.Location = new System.Drawing.Point(230, 95);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 50;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(700, 300);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.TabStop = false;
            // 
            // longtt_ptpmudDataSet
            // 
            this.longtt_ptpmudDataSet.DataSetName = "longtt_ptpmudDataSet";
            this.longtt_ptpmudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.longtt_ptpmudDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tvCategory
            // 
            this.tvCategory.BackColor = System.Drawing.Color.White;
            this.tvCategory.Location = new System.Drawing.Point(3, 3);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Size = new System.Drawing.Size(185, 565);
            this.tvCategory.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.filterLine);
            this.Controls.Add(this.navLine);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductForm";
            this.Size = new System.Drawing.Size(1280, 630);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longtt_ptpmudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel navLine;
        private System.Windows.Forms.Panel lineSearch;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.Panel filterLine;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private longtt_ptpmudDataSet longtt_ptpmudDataSet;
        private longtt_ptpmudDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TreeView tvCategory;
    }
}
