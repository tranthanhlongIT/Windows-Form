using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;
using Project2.Forms.Components;

namespace Project2.UserControls
{
    public partial class SalesForm : UserControl
    {
        private ProductBUS prodBUS;
        private CategoryBUS cateBUS;
        private List<Product> products;
        private Product product;
        private Employee employee;
        private bool isEnabled = false;

        public SalesForm()
        {
            InitializeComponent();
        }

        public void SetEmployee(Employee employee)
        {
            this.employee = employee;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitializeBUS();
                LoadFilterComboBox();
                LoadSearchTextBox();
            }
        }

        private void InitializeBUS()
        {
            prodBUS = new ProductBUS();
            cateBUS = new CategoryBUS();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by car name"))
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length < 1)
            {
                txtSearch.Text = "Search by car name";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim().ToLower();
            products = GetProductList();
            products = products.FindAll(p => p.name.ToLower().Contains(keyword));
            LoadListView(products);
            ResetDisplayField();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isEnabled = true;
            if (cbFilter.SelectedIndex == 0)
            {
                products = new ProductBUS().GetAll();
                LoadListView(products);
                ResetDisplayField();
            }
            else cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFilter.Text = cbFilter.Text;
            products = GetProductList();
            LoadListView(products);
            ResetDisplayField();
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0 && isEnabled)
            {
                ListViewItem item = lvProducts.SelectedItems[0];
                product = prodBUS.GetProductByID(Int32.Parse(item.SubItems["ID"].Text));
                SetDisplayField(product);
            }
        }

        private List<Product> GetProductList()
        {
            if (cbFilter.SelectedIndex == 0)
                return new ProductBUS().GetAll();
            else return new ProductBUS().GetProductByTypeID((int)cbFilter.SelectedValue);
        }

        public void SetDisplayField(Product product)
        {
            if (product.image != null)
                pbImage.Image = ConvertImage.ConvertBinaryToImage(product.image.ToArray());
            else pbImage.Image = pbImage.InitialImage;
            lblName.Text = "Name: " + product.name;
            lblType.Text = "Type: " + product.Category.name;
            lblBrand.Text = "Brand: " + product.Category1.name;
            lblPrice.Text = "Price: " + ((double)product.price).ToString("c0");
            lblDiscount.Text = "Discount: " + ((double)product.discount).ToString("c0");
            lblQuantity.Text = "Available stock: " + product.quantity;
            btnSell.Visible = true;
        }

        private void ResetDisplayField()
        {
            pbImage.Image = pbImage.InitialImage;
            lblName.Text = "Name: ";
            lblType.Text = "Type: ";
            lblBrand.Text = "Brand: ";
            lblPrice.Text = "Price: ";
            lblDiscount.Text = "Discount: ";
            lblQuantity.Text = "Available stock: ";
            btnSell.Visible = false;
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by car name";
            txtSearch.ForeColor = Color.Silver;
        }

        private void LoadFilterComboBox()
        {
            List<Category> categories = cateBUS.GetCategoryByParentID(24);
            categories.Insert(0, new Category() { id = 0, name = "All" });
            cbFilter.DataSource = categories;
            cbFilter.DisplayMember = "name";
            cbFilter.ValueMember = "id";
            cbFilter.SelectedIndex = 0;
        }

        private void LoadListView(List<Product> products)
        {
            lvProducts.Clear();
            if (products.Count > 0 && products != null)
            {
                int i = 0;
                lvProducts.BeginUpdate();
                lvProducts.LargeImageList = SetImageList(products);
                foreach (var product in products)
                {
                    if (product.available ?? default(bool))
                    {
                        ListViewItem item = new ListViewItem(product.name);
                        item.ImageIndex = i;

                        ListViewItem.ListViewSubItem subItemID = new ListViewItem.ListViewSubItem();
                        subItemID.Name = "ID";
                        subItemID.Text = product.id.ToString();
                        item.SubItems.Add(subItemID);

                        lvProducts.Items.Add(item);
                        i++;
                    }
                }
                lvProducts.EndUpdate();
            }
        }

        private ImageList SetImageList(List<Product> products)
        {
            imgListProduct.Images.Clear();
            foreach (var product in products)
            {
                if (product.image != null)
                    imgListProduct.Images.Add(ConvertImage.ConvertBinaryToImage(product.image.ToArray()));
                else imgListProduct.Images.Add(pbImage.InitialImage);
            }
            return imgListProduct;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            OpenModal(product, employee);
        }

        private void OpenModal(Product product, Employee employee)
        {
            Form formBackground = new Form();
            try
            {
                using (CheckoutForm uu = new CheckoutForm(product, employee))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
