using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Ultils;

namespace Project2.Forms.Components
{
    public partial class ProductModalForm : Form
    {
        private ProductBUS prodBUS;
        private CategoryBUS cateBUS;
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

        private void InitializeBUS()
        {
            prodBUS = new ProductBUS();
            cateBUS = new CategoryBUS();
        }

        private void ProductModalForm_Load(object sender, EventArgs e)
        {
            InitializeBUS();
            SetForm();
            SetBinding();
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
                lblTitle.Text = "Add Product";
                CreateProduct();
                LoadTypeComboBox();
                LoadAvailableComboBox();
                cbType.Text = string.Empty;
                cbBrand.Enabled = false;
                pbUploadImage.Image = pbUploadImage.InitialImage;
            }
            else if (action == "upd")
            {
                lblTitle.Text = "Update Product";
                product = prodBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id);
                LoadAvailableComboBox();
                SetField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Product";
                product = prodBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id);
                LoadAvailableComboBox();
                SetField();
                DisableField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
        }

        private void SetBinding()
        {
            try
            {
                bindingSourceProduct.DataSource = product;
                txtId.DataBindings.Add(new Binding("Text", bindingSourceProduct, "id"));
                txtName.DataBindings.Add(new Binding("Text", bindingSourceProduct, "name"));
                txtPrice.DataBindings.Add(new Binding("Text", bindingSourceProduct, "price"));
                txtQuantity.DataBindings.Add(new Binding("Text", bindingSourceProduct, "quantity"));
                cbType.DataBindings.Add(new Binding("SelectedValue", bindingSourceProduct, "type_id"));
                cbBrand.DataBindings.Add(new Binding("SelectedValue", bindingSourceProduct, "brand_id"));
                bindingSourceProduct.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetField()
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

        private void ResetField()
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

        private void DisableField()
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
        }

        private void SetVisibleForCreatedAtAndUpdatedAt()
        {
            lblCreatedAt.Visible = true;
            lblUpdatedAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
        }

        private void LoadTypeComboBox()
        {
            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
            categories = cateBUS.GetCategoryByParentID(24);
            cbType.DataSource = categories;
        }

        private void LoadBrandComboBox(int parentId)
        {
            cbBrand.DisplayMember = "name";
            cbBrand.ValueMember = "id";
            categories = cateBUS.GetCategoryByParentID(parentId);
            cbBrand.DataSource = categories;
        }

        private void LoadAvailableComboBox()
        {
            cbAvailable.DisplayMember = "Key";
            cbAvailable.ValueMember = "Value";
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            dict.Add("Yes", true);
            dict.Add("No", false);
            cbAvailable.DataSource = new BindingSource(dict, null);
        }

        private void CreateProduct()
        {
            this.product = new Product();
        }

        private void SetProduct()
        {
            product.name = txtName.Text.Trim();
            product.description = txtDescription.Text.Trim();
            product.price = Double.Parse(txtPrice.Text.Trim());
            product.discount = Double.Parse(txtDiscount.Text.Trim());
            product.quantity = SetQuantity();
            product.available = (bool)cbAvailable.SelectedValue;
            product.image = ConvertImage.ConvertImageToBinary(pbUploadImage.Image);
            product.created_at = SetCreatedAt();
            product.updated_at = SetUpdatedAt();
            product.type_id = (Int32)cbType.SelectedValue;
            product.brand_id = (Int32)cbBrand.SelectedValue;
        }

        private void BeginAdd()
        {
            if (product.IsValid)
            {
                SetProduct();
                bool result = prodBUS.AddNew(product);
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
            else MessageBox.Show(product.Error);
        }

        private void BeginUpdate()
        {
            if (product.IsValid)
            {
                SetProduct();
                bool result = prodBUS.Update(product);
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

        private int SetQuantity()
        {
            if (txtQuantity.Text.Trim() != "" || txtQuantity.Text.Length > 0)
                return Int32.Parse(txtQuantity.Text.Trim());
            return 0;
        }

        private DateTime SetCreatedAt()
        {
            if (action == "add")
                return DateTime.Now;
            else return DateTime.Parse(txtCreatedAt.Text);
        }

        private DateTime SetUpdatedAt()
        {
            if (action == "add")
                return DateTime.Parse(txtUpdatedAt.Text);
            else return DateTime.Now;
        }
    }
}
