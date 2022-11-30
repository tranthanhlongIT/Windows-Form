using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;
using System.Text.RegularExpressions;

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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public void SetForm()
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
                VisibleField();
            }
        }

        public void SetField()
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
            else pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        public void ResetField()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cbRole.SelectedIndex = 1;
            cbActive.SelectedIndex = 1;
            cbGender.SelectedIndex = 1;
            pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        public void DisableField()
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
            lblRequiredActive.Visible = false;
            lblRequiredFName.Visible = false;
            lblRequiredLName.Visible = false;
            lblRequiredPhone.Visible = false;
        }

        public void VisibleField()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
        }

        public void LoadRoleComboBox()
        {
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "id";
            cbRole.DataSource = RoleBUS.GetAll();
        }

        public void LoadActiveComboBox()
        {
            cbActive.DisplayMember = "Key";
            cbActive.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Enable", true);
            dict.Add("Disable", false);
            cbActive.DataSource = new BindingSource(dict, null);
        }

        public void LoadGenderComboBox()
        {
            cbGender.DisplayMember = "Key";
            cbGender.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Male", true);
            dict.Add("Female", false);
            cbGender.DataSource = new BindingSource(dict, null);
        }

        public void CreateEmployee()
        {
            this.employee = new Employee();
        }

        public void SetEmployee()
        {
            employee.fname = txtFName.Text.Trim();
            employee.lname = txtLName.Text.Trim();
            employee.address = txtAddress.Text.Trim();
            employee.phone = txtPhone.Text.Trim();
            employee.gender = (bool)cbGender.SelectedValue;
            employee.is_active = (bool)cbActive.SelectedValue;
            employee.created_at = DateTime.Now;
        }

        public void BeginAdd()
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

        public void BeginUpdate()
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

        public bool ValidateForm()
        {
            if (cbActive.SelectedValue == null)
            {
                MessageBox.Show("Active is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFName.Text.Trim() == "" || txtFName.Text.Length < 1)
            {
                MessageBox.Show("First Name field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLName.Text.Trim() == "" || txtLName.Text.Length < 1)
            {
                MessageBox.Show("Last Name field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhone.Text.Trim() == "" || txtFName.Text.Length < 1)
            {
                MessageBox.Show("Phone number field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
