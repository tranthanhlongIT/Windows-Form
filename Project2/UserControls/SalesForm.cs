using System;
using System.Globalization;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Utils;

namespace Project2.UserControls
{
    public partial class SalesForm : UserControl
    {
        ProductBUS prodBUS;
        CategoryBUS cateBUS;
        
        public SalesForm()
        {
            InitializeComponent();
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

        public void InitializeBUS()
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
            List<Product> products = prodBUS.GetAll();
            products = products.FindAll(p => p.name.ToLower().Contains(keyword));
            LoadListView(products);
            ResetDisplayField();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFilter.Text = cbFilter.Text;
            List<Product> products;
            if (cbFilter.SelectedIndex == 0)
                products = prodBUS.GetAll();
            else products = prodBUS.GetProductByTypeID((int)cbFilter.SelectedValue);
            LoadListView(products);
            ResetDisplayField();
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProducts.SelectedItems[0];
                pbImage.Image = imgListProduct.Images[item.ImageIndex];
                lblName.Text = "Name: " + item.SubItems["Name"].Text;
                lblType.Text = "Type: " + item.SubItems["Type"].Text;
                lblBrand.Text = "Brand: " + item.SubItems["Brand"].Text;
                lblPrice.Text = "Price: " + item.SubItems["Price"].Text;
                lblDiscount.Text = "Discount: " + item.SubItems["Discount"].Text;
                lblFinalPrice.Text = "Final Price: " + item.SubItems["FinalPrice"].Text;
                lblQuantity.Text = "Quantity: " + item.SubItems["Quantity"].Text;
                btnSell.Visible = true;
            }
        }

        public void ResetDisplayField()
        {
            pbImage.Image = pbInitializeImage.Image;
            lblName.Text = "Name: ";
            lblType.Text = "Type: ";
            lblBrand.Text = "Brand: ";
            lblPrice.Text = "Price: ";
            lblDiscount.Text = "Discount: ";
            lblFinalPrice.Text = "Final Price: ";
            lblQuantity.Text = "Quantity: ";
            btnSell.Visible = false;
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by car name";
            txtSearch.ForeColor = Color.Silver;
        }

        public void LoadFilterComboBox()
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
            if (products.Count > 0)
            {
                int i = 0;
                lvProducts.LargeImageList = null;
                lvProducts.LargeImageList = SetImageList(products);

                foreach (var product in products)
                {
                    if (product.available ?? default(bool))
                    {
                        ListViewItem item = new ListViewItem(product.name);
                        item.ImageIndex = i;

                        ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                        subItem1.Name = "Name";
                        subItem1.Text = product.name;
                        item.SubItems.Add(subItem1);

                        ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                        subItem2.Name = "Type";
                        subItem2.Text = product.Category.name;
                        item.SubItems.Add(subItem2);

                        ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                        subItem3.Name = "Brand";
                        subItem3.Text = product.Category1.name;
                        item.SubItems.Add(subItem3);

                        ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem();
                        subItem4.Name = "Price";
                        double price = (double)product.price;
                        subItem4.Text = price.ToString("c0");
                        item.SubItems.Add(subItem4);

                        ListViewItem.ListViewSubItem subItem5 = new ListViewItem.ListViewSubItem();
                        subItem5.Name = "Discount";
                        double discount = (double)product.discount;
                        subItem5.Text = discount.ToString("c0");
                        item.SubItems.Add(subItem5);

                        ListViewItem.ListViewSubItem subItem6 = new ListViewItem.ListViewSubItem();
                        subItem6.Name = "FinalPrice";
                        double finalPrice = (double)(product.price - product.discount);
                        subItem6.Text = finalPrice.ToString("c0");
                        item.SubItems.Add(subItem6);

                        ListViewItem.ListViewSubItem subItem7 = new ListViewItem.ListViewSubItem();
                        subItem7.Name = "Quantity";
                        subItem7.Text = product.quantity.ToString();
                        item.SubItems.Add(subItem7);

                        lvProducts.Items.Add(item);
                        i++;
                    }
                }
            }
        }

        public ImageList SetImageList(List<Product> products)
        {
            imgListProduct.Images.Clear();
            foreach (var product in products)
            {
                if (product.image != null)
                    imgListProduct.Images.Add(ConvertImage.ConvertBinaryToImage(product.image.ToArray()));
                else imgListProduct.Images.Add(pbInitializeImage.Image);
            }
            return imgListProduct;
        }
    }
}
