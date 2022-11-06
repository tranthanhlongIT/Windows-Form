
namespace Project2
{
    partial class ManagementForm
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlLineActive = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new Project2.Forms.Components.RoundedPictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblLogo);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 40);
            this.pnlTop.TabIndex = 21;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::Project2.Properties.Resources.minimize_icon;
            this.btnMinimize.Location = new System.Drawing.Point(1190, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 35);
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnClose.Image = global::Project2.Properties.Resources.close_icon;
            this.btnClose.Location = new System.Drawing.Point(1235, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 35);
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(70, 10);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(306, 25);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Shop Management System";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Project2.Properties.Resources.logo_icon;
            this.pbLogo.Location = new System.Drawing.Point(10, -5);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNavigation.Controls.Add(this.lblRole);
            this.pnlNavigation.Controls.Add(this.pbUser);
            this.pnlNavigation.Controls.Add(this.pnlLineActive);
            this.pnlNavigation.Controls.Add(this.pnlLine);
            this.pnlNavigation.Controls.Add(this.btnHistory);
            this.pnlNavigation.Controls.Add(this.btnCustomer);
            this.pnlNavigation.Controls.Add(this.btnSale);
            this.pnlNavigation.Controls.Add(this.btnCategory);
            this.pnlNavigation.Controls.Add(this.btnEmployee);
            this.pnlNavigation.Controls.Add(this.btnProduct);
            this.pnlNavigation.Controls.Add(this.btnDashboard);
            this.pnlNavigation.Controls.Add(this.lblUsername);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 40);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(1280, 50);
            this.pnlNavigation.TabIndex = 22;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRole.Location = new System.Drawing.Point(1095, 25);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(45, 21);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role";
            // 
            // pnlLineActive
            // 
            this.pnlLineActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlLineActive.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLineActive.Location = new System.Drawing.Point(0, 47);
            this.pnlLineActive.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineActive.Name = "pnlLineActive";
            this.pnlLineActive.Size = new System.Drawing.Size(115, 3);
            this.pnlLineActive.TabIndex = 1;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.Silver;
            this.pnlLine.Location = new System.Drawing.Point(0, 48);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(1280, 2);
            this.pnlLine.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistory.Enabled = false;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnHistory.Location = new System.Drawing.Point(650, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 50);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "HISTORY";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.btnHistory_MouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnHistory_MouseLeave);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustomer.Enabled = false;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnCustomer.Location = new System.Drawing.Point(540, 0);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(110, 50);
            this.btnCustomer.TabIndex = 13;
            this.btnCustomer.Text = "CUSTOMERS";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            this.btnCustomer.MouseEnter += new System.EventHandler(this.btnCustomer_MouseEnter);
            this.btnCustomer.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSale.Enabled = false;
            this.btnSale.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnSale.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnSale.Location = new System.Drawing.Point(460, 0);
            this.btnSale.Margin = new System.Windows.Forms.Padding(0);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(80, 50);
            this.btnSale.TabIndex = 9;
            this.btnSale.Text = "SALES";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            this.btnSale.MouseEnter += new System.EventHandler(this.btnSell_MouseEnter);
            this.btnSale.MouseLeave += new System.EventHandler(this.btnSell_MouseLeave);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCategory.Enabled = false;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnCategory.Location = new System.Drawing.Point(340, 0);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(120, 50);
            this.btnCategory.TabIndex = 8;
            this.btnCategory.Text = "CATEGORIES";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.MouseEnter += new System.EventHandler(this.btnCategory_MouseEnter);
            this.btnCategory.MouseLeave += new System.EventHandler(this.btnCategory_MouseLeave);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployee.Enabled = false;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmployee.Location = new System.Drawing.Point(230, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(110, 50);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "EMPLOYEES";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            this.btnEmployee.MouseEnter += new System.EventHandler(this.btnEmployee_MouseEnter);
            this.btnEmployee.MouseLeave += new System.EventHandler(this.btnEmployee_MouseLeave);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProduct.Enabled = false;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProduct.Location = new System.Drawing.Point(120, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(110, 50);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "PRODUCTS";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseEnter += new System.EventHandler(this.btnProduct_MouseEnter);
            this.btnProduct.MouseLeave += new System.EventHandler(this.btnProduct_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDashboard.Enabled = false;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(120, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsername.Location = new System.Drawing.Point(1095, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 21);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.BackColor = System.Drawing.Color.White;
            this.pbUser.InitialImage = global::Project2.Properties.Resources.user_icon_default;
            this.pbUser.Location = new System.Drawing.Point(1050, 5);
            this.pbUser.Margin = new System.Windows.Forms.Padding(0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(40, 40);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 11;
            this.pbUser.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 90);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1280, 630);
            this.pnlContainer.TabIndex = 23;
            // 
            // ManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pnlLineActive;
        private System.Windows.Forms.Panel pnlLine;
        private Forms.Components.RoundedPictureBox pbUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnlContainer;
    }
}