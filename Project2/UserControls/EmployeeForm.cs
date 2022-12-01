using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Forms.Components;
using Project2.Utils;

namespace Project2.UserControls
{
    public partial class EmployeeForm : UserControl
    {
        private List<Employee> employees;
        private int id;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadSearchTextBox();
                RefreshDataGridView();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by employee name"))
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length < 1)
            {
                txtSearch.Text = "Search by employee name";
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
            employees = GetEmployeeList();
            employees = employees.FindAll(c =>
                c.fname.ToLower().Contains(keyword) ||
                c.lname.ToLower().Contains(keyword));
            LoadDataGridView(employees);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenModal("add", -99);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                id = (Int32)dgvEmployee.Rows[dgvEmployee.CurrentRow.Index].Cells[0].Value;
                OpenModal("upd", id);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            id = (Int32)dgvEmployee.Rows[dgvEmployee.CurrentRow.Index].Cells[0].Value;
            if (dgvEmployee.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to disable?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool result = EmployeeBUS.Disable(id);
                    if (result)
                    {
                        Alert.Show("Disable Successful", Form_Alert.enmType.Success);
                        RefreshDataGridView();
                    }
                    else
                    {
                        Alert.Show("Disable Failed", Form_Alert.enmType.Warning);
                    }
                }
            }
        }

        private void btnRPassword_Click(object sender, EventArgs e)
        {
            id = (Int32)dgvEmployee.Rows[dgvEmployee.CurrentRow.Index].Cells[0].Value;
            if (dgvEmployee.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to reset password?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool result = EmployeeBUS.ResetPassword(id);
                    if (result)
                    {
                        Alert.Show("Reset Password Successful", Form_Alert.enmType.Success);
                        RefreshDataGridView();
                    }
                    else
                    {
                        Alert.Show("Reset Password Failed", Form_Alert.enmType.Warning);

                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                id = (Int32)dgvEmployee.Rows[dgvEmployee.CurrentRow.Index].Cells[0].Value;
                OpenModal("det", id);
            }
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by employee name";
            txtSearch.ForeColor = Color.Silver;
        }

        private List<Employee> GetEmployeeList()
        {
            return EmployeeBUS.GetAll();
        }

        private void LoadDataGridView(List<Employee> employees)
        {
            dgvEmployee.Rows.Clear();
            if (employees.Count > 0)
            {
                foreach (var employee in employees)
                {                    
                    dgvEmployee.Rows.Add(employee.id,
                                         employee.email,
                                         SetNameField(employee),
                                         employee.Role.name,
                                         SetGenderField(employee),
                                         employee.phone,
                                         SetActiveField(employee));
                }
            }   
        }

        private void RefreshDataGridView()
        {
            employees = GetEmployeeList();
            LoadDataGridView(employees);
        }

        private string SetNameField(Employee employee)
        {
            return employee.fname + " " + employee.lname;
        }

        private string SetGenderField(Employee employee)
        {
            if (employee.gender == true)
                return "Male";
            else return "Female";
        }

        private string SetActiveField(Employee employee)
        {
            if (employee.is_active == true)
                return "Yes";
            else return "No";
        }

        private void OpenModal(string action, int id)
        {
            Form formBackground = new Form();
            try
            {
                using (EmployeeModalForm uu = new EmployeeModalForm(action, id))
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
            catch
            {
                Alert.Show("Open Failed", Form_Alert.enmType.Warning);
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
    }
}
