﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;
using System.Text.RegularExpressions;

namespace Project2.Forms.Components
{
    public partial class CustomerModalForm : Form
    {
        private List<City> cities;
        private Customer customer;
        private string action;
        private int id;

        public CustomerModalForm()
        {
            InitializeComponent();
        }

        public CustomerModalForm(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
        }

        private void CustomerModalForm_Load(object sender, EventArgs e)
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
                lblTitle.Text = "Add Customer";
                CreateCustomer();
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadCityComboBox();
            }
            else if (action == "upd")
            {
                lblTitle.Text = "Update Customer";
                customer = CustomerBUS.GetCustomerByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadCityComboBox();
                SetField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Customer";
                customer = CustomerBUS.GetCustomerByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadCityComboBox();
                SetField();
                DisableField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
        }

        public void SetField()
        {
            txtId.Text = customer.id.ToString();
            txtFName.Text = customer.fname;
            txtLName.Text = customer.lname;
            txtPhone.Text = customer.phone;
            txtAddress.Text = customer.address;
            txtZipcode.Text = customer.zipcode;
            cbActive.SelectedValue = customer.is_active;
            cbGender.SelectedValue = customer.gender;
            cbCity.SelectedValue = customer.city_id;
            txtCreatedAt.Text = customer.created_at.ToString();
            txtUpdatedAt.Text = customer.updated_at.ToString();
        }

        public void ResetField()
        {
            txtId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtZipcode.Text = "";
            cbActive.Text = "";
            cbGender.Text = "";
            cbCity.Text = "";
            txtCreatedAt.Text = "";
            txtUpdatedAt.Text = "";
        }

        public void DisableField()
        {
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtZipcode.Enabled = false;
            cbActive.Enabled = false;
            cbGender.Enabled = false;
            cbCity.Enabled = false;
            txtCreatedAt.Enabled = false;
            txtUpdatedAt.Enabled = false;
            btnConfirm.Visible = false;
            lblRequiredActive.Visible = false;
            lblRequiredFName.Visible = false;
            lblRequiredLName.Visible = false;
            lblRequiredPhone.Visible = false;
        }

        public void SetVisibleForCreatedAtAndUpdatedAt()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
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

        public void LoadCityComboBox()
        {
            cbCity.DisplayMember = "name";
            cbCity.ValueMember = "id";
            cities = CityBUS.GetAll();
            cbCity.DataSource = cities;
        }

        public void CreateCustomer()
        {
            this.customer = new Customer();
        }

        public void SetCustomer()
        {
            customer.fname = txtFName.Text.Trim();
            customer.lname = txtLName.Text.Trim();
            customer.address = txtAddress.Text.Trim();
            customer.phone = txtPhone.Text.Trim();
            customer.zipcode = txtZipcode.Text.Trim();
            customer.gender = (bool)cbGender.SelectedValue;
            customer.is_active = (bool)cbActive.SelectedValue;
            customer.city_id = (Int32)cbCity.SelectedValue;
        }

        public void BeginAdd()
        {
            if (ValidateForm())
            {
                SetCustomer();
                bool result = CustomerBUS.AddNew(customer);
                if (result)
                {
                    CreateCustomer();
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
                SetCustomer();
                bool result = CustomerBUS.Update(customer);
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
