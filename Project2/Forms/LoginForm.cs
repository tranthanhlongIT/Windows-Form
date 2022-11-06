using System;
using System.Windows.Forms;
using Project2.BUS;

namespace Project2.Forms
{
    public partial class LoginForm : Form
    {
        private EmployeeBUS empBUS;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                txtEmail.Focus();
                InitializeBUS();
            }
        }

        private void InitializeBUS()
        {
            empBUS = new EmployeeBUS();
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
                bool result = empBUS.CheckEmployeeCredential(employee);
                if (result)
                {
                    employee = empBUS.GetEmployeeByEmail(txtEmail.Text.Trim());
                    new ManagementForm(employee).Show();
                    this.Hide();
                }
                else
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Login Failed", "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateLogin()
        {
            if (txtEmail.Text.Trim() == "" || txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Email field is empty", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Length < 1)
            {
                MessageBox.Show("Password field is empty", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (empBUS.ValidateEmail(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email doesn't exist", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
