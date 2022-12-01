using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Project2.Utils;
using Project2.BUS;

namespace Project2.Forms.Components
{
    public partial class CheckoutForm : Form
    {
        private Product product;
        private List<Customer> customers;
        private Employee employee;
        private Order order;
        private double totalPrice;

        public CheckoutForm()
        {
            InitializeComponent();
        }

        public CheckoutForm(Product product, Employee employee)
        {
            InitializeComponent();
            this.product = product;
            this.employee = employee;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            CreateOrder();
            LoadSearchTextBox();
            RefreshDataGridView();
            SetProductField(product);
            SetTotalPrice();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by customer name"))
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length < 1)
            {
                txtSearch.Text = "Search by customer name";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim().ToLower();
            customers = GetCustomerList();
            customers = customers.FindAll(c =>
                c.fname.ToLower().Contains(keyword) ||
                c.lname.ToLower().Contains(keyword));
            LoadDataGridView(customers);
        }

        private void txtQuantity_MouseLeave(object sender, EventArgs e)
        {
            SetTotalPrice();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetTotalPrice();
                e.SuppressKeyPress = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by customer name";
            txtSearch.ForeColor = Color.Silver;
        }

        private void SetProductField(Product product)
        {
            txtName.Text = product.name;
            txtType.Text = product.Category.name;
            txtBrand.Text = product.Category1.name;
            txtPrice.Text = ((double)product.price).ToString("c0");
            txtDiscount.Text = ((double)product.discount).ToString("c0");
            txtTotal.Text = ((double)(product.price - product.discount)).ToString("c0");
            if (product.image != null)
                pbImage.Image = ConvertImage.ConvertBinaryToImage(product.image.ToArray());
            else pbImage.Image = pbImage.InitialImage;
        }

        private void SetTotalPrice()
        {
            if (txtQuantity.Text.Length > 0)
            {
                totalPrice = (double)(product.price - product.discount) * Int32.Parse(txtQuantity.Text);
                txtTotal.Text = totalPrice.ToString("c0");
            }
            else
            {
                txtQuantity.Text = "0";
                txtTotal.Text = "$0";
            }
        }

        private List<Customer> GetCustomerList()
        {
            return CustomerBUS.GetAll();
        }

        private void LoadDataGridView(List<Customer> customers)
        {
            dgvCustomer.Rows.Clear();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {
                    dgvCustomer.Rows.Add(customer.id,
                                        customer.fname,
                                        customer.lname,
                                        customer.phone);
                }
            }
        }

        private void RefreshDataGridView()
        {
            customers = GetCustomerList();
            LoadDataGridView(customers);
        }

        private void CreateOrder()
        {
            order = new Order();
        }

        private void SetOrder()
        {
            order.employee_id = employee.id;
            order.customer_id = (Int32)dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value;
            order.product_id = product.id;
            order.quantity = Int32.Parse(txtQuantity.Text);
            order.total = totalPrice;
            order.created_at = DateTime.Now;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (ValidateQuantity())
            {
                SetOrder();
                bool result = OrderBUS.AddNew(order);
                if (result)
                {
                    product.quantity -= Int32.Parse(txtQuantity.Text);
                    result = ProductBUS.Update(product);
                    if (result)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        Alert.Show("Sell Successful", Form_Alert.enmType.Success);
                    }
                    else
                    {
                        Alert.Show("Sell Failed", Form_Alert.enmType.Error);
                    }
                }
                else
                {
                    Alert.Show("Sell Failed", Form_Alert.enmType.Error);
                }
            }
        }

        private bool ValidateQuantity()
        {
            if (txtQuantity.Text.Trim() == "0")
            {
                MessageBox.Show("Cannot sell 0 item", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Double.Parse(txtQuantity.Text) > product.quantity)
            {
                MessageBox.Show("Out of available stock range", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
