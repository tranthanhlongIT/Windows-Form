using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Project2.BUS;

namespace Project2
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private EmployeeBUS empBUS = new EmployeeBUS();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
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

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                Employee employee = new Employee()
                {
                    email = txtEmail.Text.Trim(),
                    password = txtPassword.Text.Trim()
                };
                bool result = empBUS.CheckEmployeePassword(employee);
                if (result)
                {
                    this.Hide();
                    new ManagementForm(employee).Show();
                }
                else
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Login Failed", "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lblCreateAccount.ForeColor = Color.LightSkyBlue;
        }

        private void lbCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCreateAccount.ForeColor = Color.SteelBlue;
        }

        private void lbCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool ValidateLogin()
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
