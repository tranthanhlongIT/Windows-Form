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
                bool result = EmployeeBUS.CheckEmployeeCredential(employee);
                if (result)
                {
                    employee = EmployeeBUS.GetEmployeeByEmail(txtEmail.Text.Trim());
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
            if (EmployeeBUS.ValidateEmail(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email doesn't exist", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //private bool ValidateRegister()
        //{
        //    private bool ValidateRegister()
        //    {
        //        if (txtUsername.Text.Trim() == "" || txtUsername.Text.Length < 1)
        //        {
        //            MessageBox.Show("Username field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (txtEmail.Text.Trim() == "" || txtEmail.Text.Length < 1)
        //        {
        //            MessageBox.Show("Email field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (txtPassword.Text.Trim() == "" || txtPassword.Text.Length < 1)
        //        {
        //            MessageBox.Show("Password field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (txtConfirmPassword.Text.Trim() == "" || txtConfirmPassword.Text.Length < 1)
        //        {
        //            MessageBox.Show("Confirm Password is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (Regex.IsMatch(txtUsername.Text.Trim(), @"[^\w\.@-]"))
        //        {
        //            MessageBox.Show("Username contains invalid characters", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
        //        {
        //            MessageBox.Show("Invalid Email", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (txtPassword.Text.Length < 5)
        //        {
        //            MessageBox.Show("Password less than 6 characters", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            ResetPassword();
        //            return false;
        //        }
        //        if (txtPassword.Text != txtConfirmPassword.Text)
        //        {
        //            MessageBox.Show("Password and Confirm Password does not match", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            ResetPassword();
        //            return false;
        //        }
        //        if (EmployeeBUS.ValidateEmail(txtEmail.Text.Trim()))
        //        {
        //            MessageBox.Show("Email already existed", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            ResetPassword();
        //            return false;
        //        }
        //        return true;
        //    }
        //}
    }
}
