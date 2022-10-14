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
using Project2.Utils;

namespace Project2.UserControls
{
    public partial class ProductForm : UserControl
    {
        private ProductBUS prodBUS = new ProductBUS();
        private CategoryBUS cateBUS = new CategoryBUS();

        private const int pageSize = 10;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            LoadSearchTextBox();
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

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by car name";
            txtSearch.ForeColor = Color.Silver;
        }

        private void CreateParentNode(int parentId)
        {
            List<Category> categories = cateBUS.GetCategoryByParentID(parentId);
            foreach (var category in categories)
            {
                TreeNode node = new TreeNode();
                node.Text = category.name;
                node.Tag = category.id;
                CreateChildNode(node, category.id);
                tvCategory.Nodes.Add(node);
            }
        }

        private void CreateChildNode(TreeNode parentNode, int parentId)
        {
            List<Category> categories = cateBUS.GetCategoryByParentID(parentId);
            foreach (var category in categories)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = category.name;
                childNode.Tag = category.id;
                parentNode.Nodes.Add(childNode);
                CreateChildNode(childNode, category.id);
            }
        }

        private void LoadTreeView()
        {
            CreateParentNode(0);
            tvCategory.SelectedNode = tvCategory.Nodes[0].Nodes[0].Nodes[0];
            tvCategory.SelectedNode.Expand();
        }

        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int categoryId = (int)tvCategory.SelectedNode.Tag;
            LoadPagination(categoryId);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0)
            //{
            //    ListViewItem item = listView1.SelectedItems[0];
            //    txtProductID.Text = item.SubItems["ProductID"].Text;
            //    txtProductName.Text = item.SubItems["Name"].Text;
            //    txtCategoyID.Text = item.SubItems["CategoryID"].Text;
            //}
        }

        public void LoadPagination(int categoryId)
        {
            int totalItem = prodBUS.GetProductByCategoryID(categoryId).Count();
            bnProduct.BindingSource = bsProduct;
            bsProduct.CurrentChanged += new System.EventHandler(bsProduct_CurrentChanged);
            bsProduct.DataSource = new PageOffsetList(totalItem, pageSize);
        }

        private void bsProduct_CurrentChanged(object sender, EventArgs e)
        {
            //    The desired page has changed, so fetch the page of products using the "Current" offset
            int categoryId = (int)tvCategory.SelectedNode.Tag;
            int offset = (int)bsProduct.Current;
            List<Product> products = new List<Product>();
            List<Product> list = prodBUS.GetProductByCategoryID(categoryId);
            for (int i = offset; i < offset + pageSize && i < list.Count(); i++)
            {
                products.Add(list[i]);
            }
            dgvProduct.DataSource = products;
            LoadDataGridView();
        }


        public void LoadDataGridView()
        {
            dgvProduct.Columns["id"].HeaderText = "ID";
            dgvProduct.Columns["name"].HeaderText = "Name";
            dgvProduct.Columns["price"].HeaderText = "Price";
            dgvProduct.Columns["discount"].HeaderText = "Discount";
            dgvProduct.Columns["quantity"].HeaderText = "Quantity";
            dgvProduct.Columns["available"].HeaderText = "Available";

            dgvProduct.Columns["description"].Visible = false;
            dgvProduct.Columns["image"].Visible = false;
            dgvProduct.Columns["created_at"].Visible = false;
            dgvProduct.Columns["updated_at"].Visible = false;
            dgvProduct.Columns["description"].Visible = false;
            dgvProduct.Columns["category_id"].Visible = false;
            dgvProduct.Columns["Category"].Visible = false;
        }

        //private void bsProduct_CurrentChanged(object sender, EventArgs e)
        //{
        //    The desired page has changed, so fetch the page of records using the "Current" offset
        //    int categoryId = (int)tvCategory.SelectedNode.Tag;
        //    var list = prodBUS.GetProductByCategoryID(categoryId);
        //    int offset = (int)bsProduct.Current;
        //    var products = new List<Product>();
        //    for (int i = offset; i < offset + pageSize && i < totalItem; i++)
        //        products.Add(new Product
        //        {
        //            id = list[i].id,
        //            name = list[i].name,
        //            price = list[i].price,
        //            discount = list[i].discount,
        //            quantity = list[i].quantity,
        //            Category = list[i].Category,
        //            available = list[i].available
        //        });
        //    dgvProduct.DataSource = products;

        //    int categoryId = (int)tvCategory.SelectedNode.Tag;
        //    int offset = (int)bsProduct.Current;
        //    List<Product> products = new List<Product>();
        //    List<Product> list = prodBUS.GetProductByCategoryID(categoryId);
        //    for (int i = offset; i < offset + pageSize && i < totalItem; i++)
        //    {
        //        products.Add(new Product
        //        {
        //            id = list[i].id,
        //            name = list[i].name,
        //            price = list[i].price,
        //            discount = list[i].discount,
        //            quantity = list[i].quantity,
        //            Category = list[i].Category,
        //            available = list[i].available
        //        });
        //    }
        //    dgvProduct.DataSource = products;
        //}

        //private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    dgvProduct.Rows.Clear();
        //    int categoryId = Int32.Parse(tvCategory.SelectedNode.Tag.ToString());
        //    List<Product> products = prodBUS.GetProductByCategoryID(categoryId);
        //    foreach (var product in products)
        //    {
        //        dgvProduct.Rows.Add(product.id,
        //                            product.name,
        //                            String.Format("{0:n0}", product.price),
        //                            String.Format("{0:n0}", product.discount),
        //                            product.quantity,
        //                            product.Category.name);
        //    }
        //}
    }
}
