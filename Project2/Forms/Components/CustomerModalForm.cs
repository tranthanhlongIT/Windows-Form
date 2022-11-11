using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;
using System.Text.RegularExpressions;
using Project2.Ultils;

namespace Project2.Forms.Components
{
    public partial class CustomerModalForm : Form
    {
        private CustomerBUS custBUS;
        private CityBUS cityBUS;
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

        private void InitializeBUS()
        {
            custBUS = new CustomerBUS();
            cityBUS = new CityBUS();
        }

        private void CustomerModalForm_Load(object sender, EventArgs e)
        {
            InitializeBUS();
            SetForm();
            SetBinding();
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

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void SetForm()
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
                customer = custBUS.GetCustomerByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadCityComboBox();
                SetField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Customer";
                customer = custBUS.GetCustomerByID(id);
                LoadGenderComboBox();
                LoadActiveComboBox();
                LoadCityComboBox();
                SetField();
                DisableField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
        }

        private void SetBinding()
        {
            try
            {
                txtFName.DataBindings.Add(new Binding("Text", bindingSourceCustomer, "fname"));
                txtLName.DataBindings.Add(new Binding("Text", bindingSourceCustomer, "lname"));
                txtPhone.DataBindings.Add(new Binding("Text", bindingSourceCustomer, "phone"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetField()
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

        private void ResetField()
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

        private void DisableField()
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
        }

        private void SetVisibleForCreatedAtAndUpdatedAt()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
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

        private void LoadCityComboBox()
        {
            cbCity.DisplayMember = "name";
            cbCity.ValueMember = "id";
            cities = cityBUS.GetAll();
            cbCity.DataSource = cities;
        }

        private void CreateCustomer()
        {
            customer = new Customer();
        }

        private void SetCustomer()
        {
            customer.fname = txtFName.Text.Trim();
            customer.lname = txtLName.Text.Trim();
            customer.address = txtAddress.Text.Trim();
            customer.phone = txtPhone.Text.Trim();
            customer.zipcode = txtZipcode.Text.Trim();
            customer.gender = (bool?)cbGender.SelectedValue;
            customer.is_active = (bool?)cbActive.SelectedValue;
            customer.city_id = (Int32)cbCity.SelectedValue;
            customer.created_at = SetCreatedAt();
            customer.updated_at = SetUpdatedAt();
        }

        public void BeginAdd()
        {
            if (customer.IsValid)
            {
                bool result = custBUS.AddNew(customer);
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

        private void BeginUpdate()
        {
            if (customer.IsValid)
            {
                SetCustomer();
                bool result = custBUS.Update(customer);
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

        public DateTime SetCreatedAt()
        {
            if (action == "add")
                return DateTime.Now;
            else return DateTime.Parse(txtCreatedAt.Text);
        }

        public DateTime SetUpdatedAt()
        {
            if (action == "add")
                return DateTime.Parse(txtUpdatedAt.Text);
            else return DateTime.Now;
        }
    }
}
