
namespace Project2.Forms.Components
{
    partial class CheckoutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.flatTextBox6 = new Project2.Utils.FlatTextBox();
            this.flatTextBox4 = new Project2.Utils.FlatTextBox();
            this.flatTextBox2 = new Project2.Utils.FlatTextBox();
            this.flatTextBox3 = new Project2.Utils.FlatTextBox();
            this.pnlVerticalLine = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flatTextBox7 = new Project2.Utils.FlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flatTextBox5 = new Project2.Utils.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flatTextBox1 = new Project2.Utils.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlLineSearch = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.chId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblChooseCustomer = new System.Windows.Forms.Label();
            this.btnBack = new Project2.Utils.RoundedButton();
            this.btnSell = new Project2.Utils.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(38, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Checkout Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlContainer.Controls.Add(this.flatTextBox6);
            this.pnlContainer.Controls.Add(this.flatTextBox4);
            this.pnlContainer.Controls.Add(this.flatTextBox2);
            this.pnlContainer.Controls.Add(this.flatTextBox3);
            this.pnlContainer.Controls.Add(this.pnlVerticalLine);
            this.pnlContainer.Controls.Add(this.lblTotal);
            this.pnlContainer.Controls.Add(this.txtQuantity);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.txtSearch);
            this.pnlContainer.Controls.Add(this.pnlLineSearch);
            this.pnlContainer.Controls.Add(this.dgvCustomer);
            this.pnlContainer.Controls.Add(this.lblChooseCustomer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 770);
            this.pnlContainer.TabIndex = 1;
            // 
            // flatTextBox6
            // 
            this.flatTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.flatTextBox6.BorderColor = System.Drawing.SystemColors.Window;
            this.flatTextBox6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.flatTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox6.Location = new System.Drawing.Point(535, 495);
            this.flatTextBox6.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox6.MaxLength = 20;
            this.flatTextBox6.Name = "flatTextBox6";
            this.flatTextBox6.ReadOnly = true;
            this.flatTextBox6.Size = new System.Drawing.Size(150, 29);
            this.flatTextBox6.TabIndex = 0;
            this.flatTextBox6.TabStop = false;
            this.flatTextBox6.Text = "$0";
            this.flatTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flatTextBox4
            // 
            this.flatTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.flatTextBox4.BorderColor = System.Drawing.SystemColors.Window;
            this.flatTextBox4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.flatTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox4.Location = new System.Drawing.Point(535, 550);
            this.flatTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox4.MaxLength = 20;
            this.flatTextBox4.Name = "flatTextBox4";
            this.flatTextBox4.ReadOnly = true;
            this.flatTextBox4.Size = new System.Drawing.Size(150, 29);
            this.flatTextBox4.TabIndex = 0;
            this.flatTextBox4.TabStop = false;
            this.flatTextBox4.Text = "$0";
            this.flatTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.flatTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.flatTextBox2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.flatTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox2.Location = new System.Drawing.Point(535, 605);
            this.flatTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox2.MaxLength = 20;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.Size = new System.Drawing.Size(150, 29);
            this.flatTextBox2.TabIndex = 0;
            this.flatTextBox2.Text = "1";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flatTextBox3
            // 
            this.flatTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.flatTextBox3.BorderColor = System.Drawing.SystemColors.Window;
            this.flatTextBox3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.flatTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox3.Location = new System.Drawing.Point(535, 660);
            this.flatTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox3.MaxLength = 20;
            this.flatTextBox3.Name = "flatTextBox3";
            this.flatTextBox3.ReadOnly = true;
            this.flatTextBox3.Size = new System.Drawing.Size(150, 29);
            this.flatTextBox3.TabIndex = 0;
            this.flatTextBox3.TabStop = false;
            this.flatTextBox3.Text = "$0";
            this.flatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(390, 662);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 22);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtQuantity.Location = new System.Drawing.Point(390, 609);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(93, 21);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Text = "Quantity:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flatTextBox7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flatTextBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.flatTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(10, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(680, 220);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Information";
            // 
            // flatTextBox7
            // 
            this.flatTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox7.BorderColor = System.Drawing.Color.Silver;
            this.flatTextBox7.Enabled = false;
            this.flatTextBox7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.flatTextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox7.Location = new System.Drawing.Point(22, 157);
            this.flatTextBox7.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox7.Name = "flatTextBox7";
            this.flatTextBox7.Size = new System.Drawing.Size(325, 27);
            this.flatTextBox7.TabIndex = 47;
            this.flatTextBox7.Text = "Crosstrek 2022";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Brand";
            // 
            // flatTextBox5
            // 
            this.flatTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.flatTextBox5.Enabled = false;
            this.flatTextBox5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.flatTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox5.Location = new System.Drawing.Point(22, 102);
            this.flatTextBox5.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox5.Name = "flatTextBox5";
            this.flatTextBox5.Size = new System.Drawing.Size(325, 27);
            this.flatTextBox5.TabIndex = 45;
            this.flatTextBox5.Text = "Crosstrek 2022";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Type";
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.flatTextBox1.Enabled = false;
            this.flatTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.flatTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatTextBox1.Location = new System.Drawing.Point(22, 47);
            this.flatTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.Size = new System.Drawing.Size(325, 27);
            this.flatTextBox1.TabIndex = 43;
            this.flatTextBox1.Text = "Crosstrek 2022";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(390, 554);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(390, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(175, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(486, 18);
            this.txtSearch.TabIndex = 1;
            // 
            // pnlLineSearch
            // 
            this.pnlLineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlLineSearch.Location = new System.Drawing.Point(175, 35);
            this.pnlLineSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineSearch.Name = "pnlLineSearch";
            this.pnlLineSearch.Size = new System.Drawing.Size(510, 1);
            this.pnlLineSearch.TabIndex = 34;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chId,
            this.chFName,
            this.chLName,
            this.chPhone,
            this.chButton});
            this.dgvCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.White;
            this.dgvCustomer.Location = new System.Drawing.Point(10, 45);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(10);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 50;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(680, 200);
            this.dgvCustomer.TabIndex = 31;
            this.dgvCustomer.TabStop = false;
            // 
            // chId
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.chId.DefaultCellStyle = dataGridViewCellStyle19;
            this.chId.FillWeight = 10F;
            this.chId.HeaderText = "ID";
            this.chId.MaxInputLength = 10;
            this.chId.MinimumWidth = 100;
            this.chId.Name = "chId";
            this.chId.ReadOnly = true;
            // 
            // chFName
            // 
            this.chFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.chFName.DefaultCellStyle = dataGridViewCellStyle20;
            this.chFName.FillWeight = 50F;
            this.chFName.HeaderText = "First Name";
            this.chFName.MaxInputLength = 100;
            this.chFName.MinimumWidth = 100;
            this.chFName.Name = "chFName";
            this.chFName.ReadOnly = true;
            // 
            // chLName
            // 
            this.chLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.chLName.DefaultCellStyle = dataGridViewCellStyle21;
            this.chLName.FillWeight = 50F;
            this.chLName.HeaderText = "Last Name";
            this.chLName.MaxInputLength = 100;
            this.chLName.MinimumWidth = 100;
            this.chLName.Name = "chLName";
            this.chLName.ReadOnly = true;
            // 
            // chPhone
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.NullValue = null;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.chPhone.DefaultCellStyle = dataGridViewCellStyle22;
            this.chPhone.FillWeight = 50F;
            this.chPhone.HeaderText = "Phone";
            this.chPhone.MaxInputLength = 10;
            this.chPhone.MinimumWidth = 100;
            this.chPhone.Name = "chPhone";
            this.chPhone.ReadOnly = true;
            // 
            // chButton
            // 
            this.chButton.FillWeight = 20F;
            this.chButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chButton.HeaderText = "#";
            this.chButton.MinimumWidth = 10;
            this.chButton.Name = "chButton";
            this.chButton.ReadOnly = true;
            // 
            // lblChooseCustomer
            // 
            this.lblChooseCustomer.AutoSize = true;
            this.lblChooseCustomer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblChooseCustomer.Location = new System.Drawing.Point(7, 15);
            this.lblChooseCustomer.Name = "lblChooseCustomer";
            this.lblChooseCustomer.Size = new System.Drawing.Size(144, 20);
            this.lblChooseCustomer.TabIndex = 30;
            this.lblChooseCustomer.Text = "Choose Customer:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBack.BorderRadius = 4;
            this.btnBack.BorderSize = 1;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(580, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 30);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "      Cancel";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSell.BorderRadius = 4;
            this.btnSell.BorderSize = 1;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(460, 11);
            this.btnSell.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(110, 30);
            this.btnSell.TabIndex = 44;
            this.btnSell.Text = "    Sell";
            this.btnSell.TextColor = System.Drawing.Color.White;
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::Project2.Properties.Resources.car_icon;
            this.pictureBox1.Location = new System.Drawing.Point(387, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(665, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(18, 18);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project2.Properties.Resources.close_2_icon;
            this.btnClose.Location = new System.Drawing.Point(670, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
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
            // SaleModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SaleModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalForm";
            this.TopMost = true;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlVerticalLine;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private Utils.FlatTextBox flatTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlLineSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn chId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chPhone;
        private System.Windows.Forms.DataGridViewButtonColumn chButton;
        private System.Windows.Forms.Label lblChooseCustomer;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Utils.FlatTextBox flatTextBox6;
        private Utils.FlatTextBox flatTextBox4;
        private Utils.FlatTextBox flatTextBox2;
        private Utils.FlatTextBox flatTextBox3;
        private Utils.RoundedButton btnBack;
        private Utils.RoundedButton btnSell;
        private Utils.FlatTextBox flatTextBox7;
        private System.Windows.Forms.Label label3;
        private Utils.FlatTextBox flatTextBox5;
        private System.Windows.Forms.Label label2;
    }
}