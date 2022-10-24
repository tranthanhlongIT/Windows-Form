using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Project2.BUS;
using Project2.Utils;

namespace Project2.Forms.Components
{
    public partial class ModalForm : Form
    {
        private ProductBUS prodBUS;
        private CategoryBUS cateBUS;
        private List<Category> categories;
        private Product product;
        private string action;
        private int id;

        public ModalForm()
        {
            InitializeComponent();
        }

        public ModalForm(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
        }

        public void InitializeBUS()
        {
            prodBUS = new ProductBUS();
            cateBUS = new CategoryBUS();
        }

        private void ModalForm_Load(object sender, EventArgs e)
        {
            InitializeBUS();
            SetForm();
        }

        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbBrand.Enabled = true;
            LoadBrandComboBox((int)cbType.SelectedValue);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = open.FileName;
                pbUploadImage.Image = new Bitmap(open.FileName);
            }
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
                product = prodBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id ?? default(int));
                LoadAvailableComboBox();
                SetField();
                SetVisibleForCreatedAtAndUpdatedAt();
            }
            else if (action == "det")
            {
                lblTitle.Text = "View Product";
                product = prodBUS.GetProductByID(id);
                LoadTypeComboBox();
                LoadBrandComboBox(product.type_id ?? default(int));
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
            cbAvailable.SelectedIndex = cbAvailable.FindStringExact(product.available);
            txtPrice.Text = product.price.ToString();
            txtDiscount.Text = product.discount.ToString();
            txtQuantity.Text = product.quantity.ToString();
            txtCreatedAt.Text = product.created_at;
            txtUpdatedAt.Text = product.updated_at;
            if (product.image != null)
                pbUploadImage.Image = Image.FromFile(product.image);
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
            cbAvailable.SelectedIndex = 0;
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
        }

        public void SetVisibleForCreatedAtAndUpdatedAt()
        {
            lblCreatedAt.Visible = true;
            lblUpdateAt.Visible = true;
            txtCreatedAt.Visible = true;
            txtUpdatedAt.Visible = true;
        }

        public void LoadTypeComboBox()
        {
            categories = cateBUS.GetCategoryByParentID(24);
            cbType.DataSource = categories;
            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
        }

        public void LoadBrandComboBox(int parentId)
        {
            categories = cateBUS.GetCategoryByParentID(parentId);
            cbBrand.DataSource = categories;
            cbBrand.DisplayMember = "name";
            cbBrand.ValueMember = "id";
        }

        public void LoadAvailableComboBox()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Yes", "Yes");
            dict.Add("No", "No");
            cbAvailable.DataSource = new BindingSource(dict, null);
            cbAvailable.DisplayMember = "Key";
            cbAvailable.ValueMember = "Value";
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
            product.available = cbAvailable.SelectedValue.ToString().Trim();
            product.image = SetImagePath();
            product.created_at = SetCreatedAt();
            product.updated_at = SetUpdatedAt();
            product.type_id = Int32.Parse(cbType.SelectedValue.ToString());
            product.brand_id = Int32.Parse(cbBrand.SelectedValue.ToString());
        }

        public void BeginAdd()
        {
            if (ValidateForm())
            {
                SetProduct();
                bool result = prodBUS.AddNew(product);
                if (result)
                {
                    CopyImageToFolder();
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
                bool result = prodBUS.Update(product);
                if (result)
                {
                    CopyImageToFolder();
                    this.Alert("Update Successful", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Update Failed", Form_Alert.enmType.Error);
                }
            }
        }

        public string SetImagePath()
        {
            if (txtImagePath.Text != "")
            {
                return Path.Combine(@"G:\Tools\Visual Studio\Windows Form\Project2\Resources\Images\",
                                Path.GetFileName(txtImagePath.Text));
            }
            else return null;
        }

        public string SetCreatedAt()
        {
            if (action == "add")
                return DateTime.Now.ToString();
            else return txtCreatedAt.Text;
        }

        public string SetUpdatedAt()
        {
            if (action == "add")
                return txtUpdatedAt.Text;
            else return DateTime.Now.ToString();
        }

        public void CopyImageToFolder()
        {
            if (txtImagePath.Text.Trim() != "" || txtImagePath.Text.Length > 0)
            {
                File.Copy(txtImagePath.Text.Trim(),
                        Path.Combine(@"G:\Tools\Visual Studio\Windows Form\Project2\Resources\Images\",
                        Path.GetFileName(txtImagePath.Text)),
                        false);
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
            if (!double.TryParse(txtDiscount.Text.Trim(), out double _))
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
            return true;
        }
    }
}
