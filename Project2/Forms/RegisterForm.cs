using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Project2.BUS;

namespace Project2
{
    public partial class RegisterForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X)
                    + e.X, (this.Location.Y - lastLocation.Y)
                    + e.Y);
                this.Update();
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRegister.PerformClick();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRegister.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRegister.PerformClick();
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRegister.PerformClick();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateRegister())
            {
                Employee newEmployee = CreateEmployee();
                bool result = new EmployeeBUS().AddNew(newEmployee);
                if (result)
                {
                    ResetForm();
                    MessageBox.Show("Register Successful", "Signup Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ResetPassword();
                    MessageBox.Show("Register Failed", "Signup Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbBackToLogin_MouseEnter(object sender, EventArgs e)
        {
            lblBackToLogin.ForeColor = Color.LightSkyBlue;
        }

        private void lbBackToLogin_MouseLeave(object sender, EventArgs e)
        {
            lblBackToLogin.ForeColor = Color.SteelBlue;
        }

        private void lbBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Employee CreateEmployee()
        {
            return new Employee()
            {
                username = txtUsername.Text.Trim(),
                email = txtEmail.Text.Trim(),
                password = txtPassword.Text.Trim(),
                is_active = true,
                created_at = DateTime.Now.ToUniversalTime().ToString(),
                updated_at = null
            };
        }

        private bool ValidateRegister()
        {
            EmployeeBUS empBUS = new EmployeeBUS();
            if (txtUsername.Text.Trim() == "" || txtUsername.Text.Length < 1)
            {
                MessageBox.Show("Username field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Email field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Length < 1)
            {
                MessageBox.Show("Password field is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtConfirmPassword.Text.Trim() == "" || txtConfirmPassword.Text.Length < 1)
            {
                MessageBox.Show("Confirm Password is empty", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Regex.IsMatch(txtUsername.Text.Trim(), @"[^\w\.@-]"))
            {
                MessageBox.Show("Username contains invalid characters", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                MessageBox.Show("Invalid Email", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password less than 6 characters", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPassword();
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password does not match", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPassword();
                return false;
            }
            if (empBUS.ValidateEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email already existed", "Register Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPassword();
                return false;
            }
            return true;
        }

        public void ResetForm()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chbShowPassword.Checked = false;
        }

        public void ResetPassword()
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
    }
}
