using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2.BUS;

namespace Project2.UserControls
{
    public partial class ProductForm : UserControl
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
            if (txtSearch.Text.Length < 1)
            {
                txtSearch.Text = "Search by car name";
                txtSearch.ForeColor = Color.Silver;
            }
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

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
        //    if (dgvProduct.SelectedRows.Count > 0)
        //    {
        //        int id = int.Parse(dgvProduct.SelectedRows[0].Cells["id"].Value.ToString());
        //        Product Product = new ProductBUS().GetDetails(id);
        //        if (Product != null)
        //        {
        //            txtId.Text = Product.id.ToString();
        //            txtName.Text = Product.name;
        //            txtDescription.Text = Product.description;
        //            txtQuantity.Text = Product.quantity.ToString();
        //            txtPrice.Text = Product.price.ToString();
        //        }
        //    }
        }

        private void LoadData()
        {
            List<Product> products = new ProductBUS().GetAll();
            dgvProduct.Columns.Add("id", "ID");
            dgvProduct.Columns.Add("name", "Name");
            dgvProduct.Columns.Add("price", "Price");
            dgvProduct.Columns.Add("quantity", "Quantity");
            dgvProduct.Columns.Add("category_name", "Category");

            foreach (var product in products)
            {
                dgvProduct.Rows.Add(product.id, product.Category.name, product.price, product.quantity, product.Category.name);
            }
        }

        //private void loadTreeView()
        //{
        //    tvCategory.CheckBoxes = true;
        //    CategoryBUS cateBUS = new CategoryBUS();
        //    List<Category> cateList = cateBUS.getAll();
        //    foreach(var cate in cateList)
        //    {
        //        TreeNode
        //    }
        //}
    }
}
