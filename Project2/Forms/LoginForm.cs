using System;
using System.Windows.Forms;
using Project2.BUS;

namespace Project2.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                txtEmail.Focus();
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

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                Employee employee = new Employee()
                {
                    email = txtEmail.Text.Trim(),
                    password = txtPassword.Text
                };
                if (EmployeeBUS.CheckEmployeeCredential(employee))
                {
                    this.Hide();
                    employee = EmployeeBUS.GetEmployeeByEmail(txtEmail.Text.Trim());
                    ManagementForm managementForm = new ManagementForm();
                    managementForm.currentEmployee = employee;
                    managementForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateLogin()
        {
            if (txtEmail.Text.Trim() == string.Empty || txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Email field is empty", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text.Trim() == string.Empty || txtPassword.Text.Length < 1)
            {
                MessageBox.Show("Password field is empty", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (EmployeeBUS.ValidateEmail(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email doesn't exist", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
