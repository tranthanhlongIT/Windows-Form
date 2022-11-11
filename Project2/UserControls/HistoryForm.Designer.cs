
namespace Project2.UserControls
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnRefresh = new Project2.Utils.RoundedButton();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new Project2.Utils.RoundedButton();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlLineSearch = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.chId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.TabIndex = 1;
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.White;
            this.pnlOperation.Controls.Add(this.btnRefresh);
            this.pnlOperation.Controls.Add(this.dtpDateEnd);
            this.pnlOperation.Controls.Add(this.btnFilter);
            this.pnlOperation.Controls.Add(this.dtpDateStart);
            this.pnlOperation.Controls.Add(this.btnSearch);
            this.pnlOperation.Controls.Add(this.txtSearch);
            this.pnlOperation.Controls.Add(this.pnlLineSearch);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(1280, 40);
            this.pnlOperation.TabIndex = 5;
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
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(501, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 25);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "        Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            this.dtpDateEnd.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(200, 6);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDateEnd.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(180, 30);
            this.dtpDateEnd.TabIndex = 7;
            this.dtpDateEnd.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFilter.BorderRadius = 3;
            this.btnFilter.BorderSize = 1;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(400, 6);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(99, 25);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "        Filter";
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            this.dtpDateStart.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(10, 6);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDateStart.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(180, 30);
            this.dtpDateStart.TabIndex = 6;
            this.dtpDateStart.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
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
            // 
            // pnlLineSearch
            // 
            this.pnlLineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlLineSearch.Location = new System.Drawing.Point(930, 32);
            this.pnlLineSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineSearch.Name = "pnlLineSearch";
            this.pnlLineSearch.Size = new System.Drawing.Size(325, 1);
            this.pnlLineSearch.TabIndex = 4;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chId,
            this.chEmployee,
            this.chCustomer,
            this.chProduct,
            this.chQuantity,
            this.chTotal,
            this.chCreatedAt});
            this.dgvOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.Color.White;
            this.dgvOrder.Location = new System.Drawing.Point(10, 50);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(10);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 50;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(1260, 570);
            this.dgvOrder.TabIndex = 6;
            this.dgvOrder.TabStop = false;
            // 
            // chId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.chId.DefaultCellStyle = dataGridViewCellStyle3;
            this.chId.FillWeight = 10F;
            this.chId.HeaderText = "ID";
            this.chId.MaxInputLength = 10;
            this.chId.MinimumWidth = 50;
            this.chId.Name = "chId";
            this.chId.ReadOnly = true;
            // 
            // chEmployee
            // 
            this.chEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.chEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.chEmployee.FillWeight = 50F;
            this.chEmployee.HeaderText = "Employee";
            this.chEmployee.MaxInputLength = 100;
            this.chEmployee.MinimumWidth = 200;
            this.chEmployee.Name = "chEmployee";
            this.chEmployee.ReadOnly = true;
            // 
            // chCustomer
            // 
            this.chCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.chCustomer.DefaultCellStyle = dataGridViewCellStyle5;
            this.chCustomer.FillWeight = 50F;
            this.chCustomer.HeaderText = "Customer";
            this.chCustomer.MaxInputLength = 10;
            this.chCustomer.MinimumWidth = 200;
            this.chCustomer.Name = "chCustomer";
            this.chCustomer.ReadOnly = true;
            this.chCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chProduct
            // 
            this.chProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.chProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.chProduct.FillWeight = 50F;
            this.chProduct.HeaderText = "Product";
            this.chProduct.MaxInputLength = 250;
            this.chProduct.MinimumWidth = 200;
            this.chProduct.Name = "chProduct";
            this.chProduct.ReadOnly = true;
            // 
            // chQuantity
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            this.chQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.chQuantity.FillWeight = 50F;
            this.chQuantity.HeaderText = "Quantity";
            this.chQuantity.MaxInputLength = 10;
            this.chQuantity.MinimumWidth = 100;
            this.chQuantity.Name = "chQuantity";
            this.chQuantity.ReadOnly = true;
            // 
            // chTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.chTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.chTotal.FillWeight = 50F;
            this.chTotal.HeaderText = "Total";
            this.chTotal.MaxInputLength = 10;
            this.chTotal.MinimumWidth = 100;
            this.chTotal.Name = "chTotal";
            this.chTotal.ReadOnly = true;
            // 
            // chCreatedAt
            // 
            this.chCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            this.chCreatedAt.DefaultCellStyle = dataGridViewCellStyle9;
            this.chCreatedAt.FillWeight = 50F;
            this.chCreatedAt.HeaderText = "Created At";
            this.chCreatedAt.MaxInputLength = 10;
            this.chCreatedAt.MinimumWidth = 200;
            this.chCreatedAt.Name = "chCreatedAt";
            this.chCreatedAt.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.pnlOperation);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HistoryForm";
            this.Size = new System.Drawing.Size(1280, 630);
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlLineSearch;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DataGridView dgvOrder;
        private Utils.RoundedButton btnRefresh;
        private Utils.RoundedButton btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn chProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCreatedAt;
    }
}
