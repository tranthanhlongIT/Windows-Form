using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.UserControls;

namespace Project2
{
    public partial class ManagementForm : Form
    {
        private int activeBtn;
        private Employee employee;
        private ProductForm productForm;

        public ManagementForm()
        {
            InitializeComponent();
        }

        public ManagementForm(Employee emp)
        {
            InitializeComponent();
            SetUserPrivilege(emp);
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            SlidePanel(btnDashboard);
            ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnCategory, btnSale, btnHistory });
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SlidePanel(btnDashboard);
            ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnCategory, btnSale, btnCustomer, btnHistory});
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SlidePanel(btnProduct);
            ChangeButtonTextColor(2, btnProduct, new List<Button> { btnDashboard, btnEmployee, btnCategory, btnSale, btnCustomer, btnHistory });
            createTab();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SlidePanel(btnEmployee);
            ChangeButtonTextColor(3, btnEmployee, new List<Button> { btnDashboard, btnProduct, btnCategory, btnSale, btnCustomer, btnHistory });
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SlidePanel(btnCategory);
            ChangeButtonTextColor(4, btnCategory, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnSale, btnCustomer, btnHistory });
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SlidePanel(btnSale);
            ChangeButtonTextColor(5, btnSale, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCategory, btnCustomer, btnHistory });
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SlidePanel(btnCustomer);
            ChangeButtonTextColor(6, btnCustomer, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCategory, btnSale, btnHistory });
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SlidePanel(btnHistory);
            ChangeButtonTextColor(7, btnHistory, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCategory, btnSale, btnCustomer });
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.SteelBlue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 1))
                btnDashboard.ForeColor = Color.Black;
        }

        private void btnProduct_MouseEnter(object sender, EventArgs e)
        {
            btnProduct.ForeColor = Color.SteelBlue;
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 2))
                btnProduct.ForeColor = Color.Black;
        }
        private void btnEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnEmployee.ForeColor = Color.SteelBlue;
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 3))
                btnEmployee.ForeColor = Color.Black;
        }

        private void btnCategory_MouseEnter(object sender, EventArgs e)
        {
            btnCategory.ForeColor = Color.SteelBlue;
        }

        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 4))
                btnCategory.ForeColor = Color.Black;
        }

        private void btnSell_MouseEnter(object sender, EventArgs e)
        {
            btnSale.ForeColor = Color.SteelBlue;
        }

        private void btnSell_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 5))
                btnSale.ForeColor = Color.Black;
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.SteelBlue;
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 6))
                btnCustomer.ForeColor = Color.Black;
        }

        private void btnHistory_MouseEnter(object sender, EventArgs e)
        {
            btnHistory.ForeColor = Color.SteelBlue;
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 7))
                btnHistory.ForeColor = Color.Black;
        }

        private void SlidePanel(Button btn)
        {
            pnlLineActive.Width = btn.Width;
            pnlLineActive.Left = btn.Left;
        }

        private void ChangeButtonTextColor(int btnIndex, Button btnActive, List<Button> listBtn)
        {
            activeBtn = btnIndex;
            btnActive.ForeColor = Color.SteelBlue;
            foreach (Button btn in listBtn)
            {
                btn.ForeColor = Color.Black;
            }
        }

        private bool IsButtonActive(int activeBtn, int btn)
        {
            if (activeBtn == btn)
                return true;
            return false;
        }

        private void SetUserPrivilege(Employee emp)
        {
            this.employee = emp;
            SetUserDisplay();
            EnableTabBaseOnRole();
        }

        private void SetUserDisplay()
        {
            lblUsername.Text = employee.username;
            lblRole.Text = employee.Role.name;
            if (employee.image != null)
                pbUser.Image = Image.FromFile(employee.image);
            else pbUser.Image = pbUser.InitialImage;
        }

        private void EnableTabBaseOnRole()
        {
            if (employee.Role.name == "Manager")
            {
                btnDashboard.Enabled = true;
                btnProduct.Enabled = true;
                btnEmployee.Enabled = true;
                btnCategory.Enabled = true;
                btnSale.Enabled = true;
                btnCustomer.Enabled = true;
                btnHistory.Enabled = true;
            }
            else if (employee.Role.name == "Salesman")
            {
                btnDashboard.Enabled = true;
                btnSale.Enabled = true;
                btnCustomer.Enabled = true;
            }
            else if (employee.Role.name == "Accountant")
            {
                btnDashboard.Enabled = true;
                btnHistory.Enabled = true;
            }
        }

        private void createTab()
        {
            if (!pnlContainer.Controls.Contains(productForm))
            {
                productForm = new ProductForm();
                pnlContainer.Controls.Add(productForm);
                productForm.Dock = DockStyle.Fill;
            }
            else
            {
                pnlContainer.Controls.Clear();
                productForm.Dispose();    
            }
        }
    }
}
