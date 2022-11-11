using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;

namespace Project2.UserControls
{
    public partial class HistoryForm : UserControl
    {
        private List<Order> orders;

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadSearchTextBox();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by Order ID"))
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length < 1)
            {
                txtSearch.Text = "Search by Order ID";
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
            orders = GetOrderList();
            orders = orders.FindAll(o => o.id.ToString().ToLower().Contains(keyword));
            LoadDataGridView(orders);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            orders = GetOrderListBetweenDate(dtpDateStart.Value, dtpDateEnd.Value);
            LoadDataGridView(orders);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by Order ID";
            txtSearch.ForeColor = Color.Silver;
        }

        private List<Order> GetOrderList()
        {
            return OrderBUS.GetAll();
        }

        private List<Order> GetOrderListBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return OrderBUS.GetAllBetweenDate(dateStart, dateEnd);
        }

        private void LoadDataGridView(List<Order> Orders)
        {
            dgvOrder.Rows.Clear();
            if (Orders.Count > 0)
            {
                foreach (var Order in Orders)
                {
                    dgvOrder.Rows.Add(Order.id,
                                      SetEmployeeName(Order),
                                      SetCustomerName(Order),
                                      Order.Product.name,
                                      Order.quantity,
                                      Order.total,
                                      Order.created_at);
                }
            }
        }

        private String SetEmployeeName(Order order)
        {
            return order.Employee.fname + " " + order.Employee.lname;
        }

        private String SetCustomerName(Order order)
        {
            return order.Customer.fname + " " + order.Customer.lname;
        }

        private void RefreshDataGridView()
        {
            orders = GetOrderList();
            LoadDataGridView(orders);
        }
    }
}
