using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;

namespace Project2.Forms.Components
{
    public partial class ProductModalForm : Form
    {
        private List<Category> categories;
        private Product product;
        private string action;
        private int id;

        public ProductModalForm()
        {
            InitializeComponent();
        }

        public ProductModalForm(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
        }

        private void ProductModalForm_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbBrand.Enabled = true;
            LoadBrandComboBox((int)cbType.SelectedValue);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUploadImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                CreateProduct();
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
                lblTitle.Text = "Add Product";
                pbUploadImage.Image = pbUploadImage.InitialImage;
                LoadTypeComboBox();
                LoadAvailableComboBox();
                cbType.Text = "";
                cbBrand.Enabled = false;
            }
            else if (action == "upd")
            {
                lblTitle.Text = "Update Product";
                product = ProductBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id);
                LoadAvailableComboBox();
                SetField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Product";
                product = ProductBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id);
                LoadAvailableComboBox();
                SetField();
                DisableField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
        }

        public void SetField()
        {
            txtId.Text = product.id.ToString();
            txtName.Text = product.name;
            txtDescription.Text = product.description;
            cbType.SelectedValue = product.type_id;
            cbBrand.SelectedValue = product.brand_id;
            cbAvailable.SelectedValue = product.available;
            txtPrice.Text = product.price.ToString();
            txtDiscount.Text = product.discount.ToString();
            txtQuantity.Text = product.quantity.ToString();
            txtCreatedAt.Text = product.created_at.ToString();
            txtUpdatedAt.Text = product.updated_at.ToString();
            if (product.image != null)
                pbUploadImage.Image = ConvertImage.ConvertBinaryToImage(product.image.ToArray());
            else pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        public void ResetField()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            cbType.Text = "";
            cbBrand.Text = "";
            cbBrand.Enabled = false;
            cbAvailable.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            txtQuantity.Text = "";
            txtCreatedAt.Text = "";
            txtUpdatedAt.Text = "";
            pbUploadImage.Image = pbUploadImage.InitialImage;
        }

        public void DisableField()
        {
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            cbType.Enabled = false;
            cbBrand.Enabled = false;
            cbAvailable.Enabled = false;
            txtPrice.Enabled = false;
            txtDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtCreatedAt.Enabled = false;
            txtUpdatedAt.Enabled = false;
            btnConfirm.Visible = false;
            btnUploadImage.Visible = false;
            btnClearImage.Visible = false;
            lblRequiredAvailable.Visible = false;
            lblRequiredBrand.Visible = false;
            lblRequiredDiscount.Visible = false;
            lblRequiredName.Visible = false;
            lblRequiredPrice.Visible = false;
            lblRequiredQuantity.Visible = false;
            lblRequiredType.Visible = false;
        }

        public void SetVisibleForCreatedAtAndUpdatedAt()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
        }

        public void LoadTypeComboBox()
        {
            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
            categories = CategoryBUS.GetCategoryByParentID(24);
            cbType.DataSource = categories;
        }

        public void LoadBrandComboBox(int parentId)
        {
            cbBrand.DisplayMember = "name";
            cbBrand.ValueMember = "id";
            categories = CategoryBUS.GetCategoryByParentID(parentId);
            cbBrand.DataSource = categories;
        }

        public void LoadAvailableComboBox()
        {
            cbAvailable.DisplayMember = "Key";
            cbAvailable.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Yes", true);
            dict.Add("No", false);
            cbAvailable.DataSource = new BindingSource(dict, null);
        }

        public void CreateProduct()
        {
            this.product = new Product();
        }

        public void SetProduct()
        {
            product.name = txtName.Text.Trim();
            product.description = txtDescription.Text.Trim();
            product.price = Double.Parse(txtPrice.Text.Trim());
            product.discount = Double.Parse(txtDiscount.Text.Trim());
            product.quantity = Int32.Parse(txtQuantity.Text.Trim());
            product.available = (bool)cbAvailable.SelectedValue;
            product.image = ConvertImage.ConvertImageToBinary(pbUploadImage.Image);
            product.type_id = (Int32)cbType.SelectedValue;
            product.brand_id = (Int32)cbBrand.SelectedValue;
        }

        public void BeginAdd()
        {
            if (ValidateForm())
            {
                SetProduct();
                bool result = ProductBUS.AddNew(product);
                if (result)
                {
                    CreateProduct();
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
                SetProduct();
                bool result = ProductBUS.Update(product);
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
            if (txtName.Text.Trim() == "" || txtName.Text.Length < 1)
            {
                MessageBox.Show("Name field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbType.SelectedValue == null)
            {
                MessageBox.Show("Type is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbBrand.SelectedValue == null)
            {
                MessageBox.Show("Brand is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbAvailable.SelectedValue == null)
            {
                MessageBox.Show("Available is not selected yet", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrice.Text.Trim() == "" || txtPrice.Text.Length < 1)
            {
                MessageBox.Show("Price field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtPrice.Text.Trim(), out double _))
            {
                MessageBox.Show("Invalid Price", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Double.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show("Invalid Price", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDiscount.Text.Trim() == "" || txtDiscount.Text.Length < 1)
            {
                MessageBox.Show("Discount field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtDiscount.Text.Trim(), out double _))
            {
                MessageBox.Show("Invalid Discount", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Double.Parse(txtDiscount.Text) < 0)
            {
                MessageBox.Show("Invalid Discount", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtQuantity.Text.Trim() == "" || txtPrice.Text.Length < 1)
            {
                MessageBox.Show("Quantity field is empty", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtQuantity.Text.Trim(), out int _))
            {
                MessageBox.Show("Invalid Quantity", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.Parse(txtQuantity.Text) < 0)
            {
                MessageBox.Show("Invalid Quantity", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }
    }
}
