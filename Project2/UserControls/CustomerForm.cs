using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Forms.Components;

namespace Project2.UserControls
{
    public partial class CustomerForm : UserControl
    {
        private CustomerBUS custBUS;
        private List<Customer> customers;
        private int id;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                InitializeBUS();
                RefreshDataGridView();
                LoadSearchTextBox();
            }
        }

        private void InitializeBUS()
        {
            custBUS = new CustomerBUS();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by customer name"))
            {
                txtSearch.Text = "";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenModal("add", -99);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = (Int32)dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value;
            OpenModal("upd", id);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                id = Int32.Parse(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value.ToString());
                bool result = custBUS.Disable(id);
                if (result)
                {
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Disable Failed", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                id = (int)dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value;
                OpenModal("det", id);
            }
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by customer name";
            txtSearch.ForeColor = Color.Silver;
        }

        private List<Customer> GetCustomerList()
        {
            return new CustomerBUS().GetAll();
        }

        private void LoadDataGridView(List<Customer> customers)
        {
            dgvCustomer.Rows.Clear();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {                    
                    dgvCustomer.Rows.Add(customer.id,
                                        SetNameField(customer),
                                        SetGenderField(customer),
                                        customer.address,
                                        customer.phone,
                                        customer.City.name,
                                        SetActiveField(customer));
                }
            }   
        }

        private void RefreshDataGridView()
        {
            customers = GetCustomerList();
            LoadDataGridView(customers);
        }

        private string SetNameField(Customer customer)
        {
            return customer.fname + " " + customer.lname;
        }

        private string SetGenderField(Customer customer)
        {
            if (customer.gender == true)
                return "Male";
            else return "Female";
        }

        private string SetActiveField(Customer customer)
        {
            if (customer.is_active == true)
                return "Yes";
            else return "No";
        }

        private void OpenModal(string action, int id)
        {
            Form formBackground = new Form();
            try
            {
                using (CustomerModalForm uu = new CustomerModalForm(action, id))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (action != "det")
                {
                    RefreshDataGridView();
                }
                formBackground.Dispose();
            }
        }

        public void RefreshForm()
        {
            LoadSearchTextBox();
            RefreshDataGridView();
        }
    }
}
