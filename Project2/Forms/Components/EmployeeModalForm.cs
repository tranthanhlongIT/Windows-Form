using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Project2.Forms.Components
{
    public partial class EmployeeModalForm : Form
    {
        private Employee employee;
        private string action;
        private int id;

        public EmployeeModalForm()
        {
            InitializeComponent();
        }

        public EmployeeModalForm(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
        }

        private void EmployeeModalForm_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                BeginAdd();
            }
            else if (action == "upd")
            {
                BeginUpdate();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbUploadImage.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnDefaultImage_Click(object sender, EventArgs e)
        {
            pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void SetForm()
        {
            if (action == "add")
            {
                lblTitle.Text = "Add Employee";
                CreateEmployee();
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadRoleComboBox();
            }
            else if (action == "upd")
            {
                lblTitle.Text = "Update Employee";
                employee = EmployeeBUS.GetEmployeeByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadRoleComboBox();
                SetField();
                DisablePassword();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Employee";
                employee = EmployeeBUS.GetEmployeeByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadRoleComboBox();
                SetField();
                DisableField();
                VisibleTimestamp();
                InvisibleField();
            }
        }

        private void SetField()
        {
            txtEmail.Text = employee.email;
            txtFName.Text = employee.fname;
            txtLName.Text = employee.lname;
            txtPhone.Text = employee.phone;
            txtAddress.Text = employee.address;
            cbRole.SelectedValue = employee.role_id;
            cbActive.SelectedValue = employee.is_active;
            cbGender.SelectedValue = employee.gender;
            txtCreatedAt.Text = employee.created_at.ToString();
            txtUpdatedAt.Text = employee.updated_at.ToString();
            if (employee.image != null)
                pbUploadImage.Image = ConvertImage.ConvertBinaryToImage(employee.image.ToArray());
        }

        private void ResetField()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            cbActive.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        private void DisablePassword()
        {
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            lblRequiredPassword.Visible = false;
            lblRequiredConfirmPassword.Visible = false;
        }

        private void DisableField()
        {
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            cbActive.Enabled = false;
            cbGender.Enabled = false;
            cbRole.Enabled = false;
            pbUploadImage.Enabled = false;
        }

        private void InvisibleField()
        {
            btnConfirm.Visible = false;
            btnUploadImage.Visible = false;
            btnDefaultImage.Visible = false;
            lblRequiredRole.Visible = false;
            lblRequiredActive.Visible = false;
            lblRequiredEmail.Visible = false;
            lblRequiredPassword.Visible = false;
            lblRequiredConfirmPassword.Visible = false;
            lblRequiredFName.Visible = false;
            lblRequiredLName.Visible = false;
            lblRequiredGender.Visible = false;
            lblRequiredPhone.Visible = false;
        }

        private void VisibleTimestamp()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
        }

        private void LoadRoleComboBox()
        {
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "id";
            cbRole.DataSource = RoleBUS.GetAll();
        }

        private void LoadActiveComboBox()
        {
            cbActive.DisplayMember = "Key";
            cbActive.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Enable", true);
            dict.Add("Disable", false);
            cbActive.DataSource = new BindingSource(dict, null);
        }

        private void LoadGenderComboBox()
        {
            cbGender.DisplayMember = "Key";
            cbGender.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Male", true);
            dict.Add("Female", false);
            cbGender.DataSource = new BindingSource(dict, null);
        }

        private void CreateEmployee()
        {
            this.employee = new Employee();
        }

        private void SetEmployee()
        {
            employee.email = txtEmail.Text.Trim();
            employee.password = txtPassword.Text.Trim();
            employee.fname = txtFName.Text.Trim();
            employee.lname = txtLName.Text.Trim();
            employee.gender = (bool)cbGender.SelectedValue;
            employee.phone = txtPhone.Text.Trim();
            employee.address = txtAddress.Text.Trim();
            employee.image = ConvertImage.ConvertImageToBinary(pbUploadImage.Image);
            employee.is_active = (bool)cbActive.SelectedValue;
            employee.role_id = (Int32)cbRole.SelectedValue;
            employee.created_at = DateTime.Now;
        }

        private void BeginAdd()
        {
            if (ValidateForm())
            {
                SetEmployee();
                bool result = EmployeeBUS.AddNew(employee);
                if (result)
                {
                    CreateEmployee();
                    ResetField();
                    this.Alert("Add Successful", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Add Failed", Form_Alert.enmType.Error);
                }
            }
        }

        private void BeginUpdate()
        {
            if (ValidateForm())
            {
                SetEmployee();
                bool result = EmployeeBUS.Update(employee);
                if (result)
                {
                    this.Alert("Update Successful", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Update Failed", Form_Alert.enmType.Error);
                }
            }
        }

        private bool ValidateForm()
        {
            if (cbRole.SelectedValue == null)
            {
                MessageBox.Show("Role is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbActive.SelectedValue == null)
            {
                MessageBox.Show("Active is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Email field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                MessageBox.Show("Invalid Email", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (action == "add" && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (action == "add" && txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Confirm Password field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (action == "add" && txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match Confirm Password", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First Name field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Last Name field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Phone number field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbGender.SelectedValue == null)
            {
                MessageBox.Show("Gender is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
