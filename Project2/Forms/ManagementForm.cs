using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.UserControls;
using Project2.Utils;
using Project2.Forms;

namespace Project2
{
    public partial class ManagementForm : Form
    {
        private int activeBtn;
        private CustomerForm customerForm;
        private EmployeeForm employeeForm;
        private ProductForm productForm;
        private DashboardForm dashboardForm;
        private HistoryForm historyForm;
        private SalesForm salesForm;
        public Employee currentEmployee { get; set; }

        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            SetUserDisplay();
            EnableTabBaseOnRole();
            CreateTabDashboard();
            SlidePanel(btnDashboard);
            ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnSale, btnHistory });
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(dashboardForm))
            {
                ClearContainer();
                CreateTabDashboard();
                SlidePanel(btnDashboard);
                ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnSale, btnCustomer, btnHistory });
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(productForm))
            {
                ClearContainer();
                CreateTabProduct();
                SlidePanel(btnProduct);
                ChangeButtonTextColor(2, btnProduct, new List<Button> { btnDashboard, btnEmployee, btnSale, btnCustomer, btnHistory });
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(employeeForm))
            {
                ClearContainer();
                CreateTabEmployee();
                SlidePanel(btnEmployee);
                ChangeButtonTextColor(3, btnEmployee, new List<Button> { btnDashboard, btnProduct, btnSale, btnCustomer, btnHistory });
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(salesForm))
            {
                ClearContainer();
                CreateTabSales();
                SlidePanel(btnSale);
                ChangeButtonTextColor(5, btnSale, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCustomer, btnHistory });
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(customerForm))
            {
                ClearContainer();
                CreateTabCustomer();
                SlidePanel(btnCustomer);
                ChangeButtonTextColor(6, btnCustomer, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnSale, btnHistory });
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!pnlContainer.Controls.Contains(historyForm))
            {
                ClearContainer();
                CreateTabHistory();
                SlidePanel(btnHistory);
                ChangeButtonTextColor(7, btnHistory, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnSale, btnCustomer });
            }
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

        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            pbLogout.Image = pbLogout.InitialImage;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            pbLogout.Image = pbLogout.ErrorImage;
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

        private void SetUserDisplay()
        {
            lblName.Text = currentEmployee.fname;
            lblRole.Text = currentEmployee.Role.name;
            if (currentEmployee.image != null)
                pbUser.Image = ConvertImage.ConvertBinaryToImage(currentEmployee.image.ToArray());
            else pbUser.Image = pbUser.InitialImage;
        }

        private void EnableTabBaseOnRole()
        {
            if (currentEmployee.Role.name == "Manager")
            {
                btnDashboard.Enabled = true;
                btnProduct.Enabled = true;
                btnEmployee.Enabled = true;
                btnSale.Enabled = true;
                btnCustomer.Enabled = true;
                btnHistory.Enabled = true;
            }
            else if (currentEmployee.Role.name == "Salesman")
            {
                btnDashboard.Enabled = true;
                btnSale.Enabled = true;
                btnCustomer.Enabled = true;
            }
            else if (currentEmployee.Role.name == "Accountant")
            {
                btnDashboard.Enabled = true;
                btnHistory.Enabled = true;
            }
        }

        private void CreateTabDashboard()
        {
            dashboardForm = new DashboardForm();
            pnlContainer.Controls.Add(dashboardForm);
            dashboardForm.Dock = DockStyle.Fill;
        }

        private void CreateTabProduct()
        {
            productForm = new ProductForm();
            pnlContainer.Controls.Add(productForm);
            productForm.Dock = DockStyle.Fill;
        }

        private void CreateTabCustomer()
        {
            customerForm = new CustomerForm();
            pnlContainer.Controls.Add(customerForm);
            customerForm.Dock = DockStyle.Fill;
        }

        private void CreateTabHistory()
        {
            historyForm = new HistoryForm();
            pnlContainer.Controls.Add(historyForm);
            historyForm.Dock = DockStyle.Fill;
        }

        private void CreateTabEmployee()
        {
            employeeForm = new EmployeeForm();
            employeeForm.currentEmployee = currentEmployee;
            pnlContainer.Controls.Add(employeeForm);
            employeeForm.Dock = DockStyle.Fill;
        }

        private void CreateTabSales()
        {
            salesForm = new SalesForm();
            salesForm.currentEmployee = currentEmployee;
            pnlContainer.Controls.Add(salesForm);
            salesForm.Dock = DockStyle.Fill;
        }

        private void ClearContainer()
        {
            pnlContainer.Controls.Clear();
            foreach (Control c in pnlContainer.Controls)
                c.Dispose();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}