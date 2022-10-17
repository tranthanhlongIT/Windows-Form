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
using Project2.Forms.Components;

namespace Project2.UserControls
{
    public partial class ProductForm : UserControl
    {
        private ProductBUS prodBUS = new ProductBUS();
        private CategoryBUS cateBUS = new CategoryBUS();

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
            List<Product> products = GetProductList();
            products = products.FindAll(p => p.name.ToLower().Contains(keyword));
            LoadDataGridView(products);
        }

        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvCategory.SelectedNode.SelectedImageIndex = tvCategory.SelectedNode.ImageIndex;
            List<Product> products = GetProductList();
            LoadDataGridView(products);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenModal("add", -99);
        }

        private void LoadSearchTextBox()
        {
            txtSearch.Text = "Search by car name";
            txtSearch.ForeColor = Color.Silver;
        }

        private void LoadTreeView()
        {
            CreateParentNode(0);
            tvCategory.SelectedNode = tvCategory.Nodes[0].FirstNode.FirstNode;
            tvCategory.SelectedNode.Expand();
            tvCategory.Focus();
        }

        public void LoadDataGridView(List<Product> products)
        {
            dgvProduct.Rows.Clear();
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    string type = prodBUS.GetProductType(product.id);
                    string brand = prodBUS.GetProductBrand(product.id);
                    dgvProduct.Rows.Add(product.id,
                                        product.name,
                                        product.price,
                                        product.discount,
                                        product.quantity,
                                        type,
                                        brand,
                                        product.available);
                }
            }   
        }

        private void CreateParentNode(int parentId)
        {
            List<Category> categories = cateBUS.GetCategoryByParentID(parentId);
            foreach (var category in categories)
            {
                TreeNode node = new TreeNode();
                node.Text = category.name;
                node.Tag = category.id;
                node.ImageIndex = 0;
                CreateChildNode(node, category.id);
                tvCategory.Nodes.Add(node);
            }
        }

        private void CreateChildNode(TreeNode parentNode, int parentId)
        {
            List<Category> categories = cateBUS.GetCategoryByParentID(parentId);
            if (categories.Count > 0)
            {
                foreach (var category in categories)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = category.name;
                    childNode.Tag = category.id;
                    childNode.ImageIndex = SetIcon(category.name);
                    parentNode.Nodes.Add(childNode);
                    CreateChildNode(childNode, category.id);
                }
            }
        }

        public List<Product> GetProductList()
        {
            int level = tvCategory.SelectedNode.Level;
            int categoryId = (int)tvCategory.SelectedNode.Tag;
            return prodBUS.GetProductByTreeLevel(level, categoryId);
        }

        private int SetIcon(string name)
        {
            switch (name)
            {
                case "Sedan": return 1;
                case "SUV": return 2;
                case "Hatchback": return 3;
                case "Sportcar": return 4;
                case "Subaru": return 5;
                case "Toyota": return 6;
                case "Lexus": return 7;
                case "BMW": return 8;
                case "Mercedes Benz": return 9;
                default: return 0;
            }
        }

        private void OpenModal(string action, int id)
        {
            Form formBackground = new Form();
            try
            {
                using (ModalForm uu = new ModalForm(action, id))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString());
            OpenModal("update", id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Int32.Parse(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString());
                bool result = new ProductBUS().Delete(id);
                if (result)
                {
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("SORRY BABY!");
                }
            }
        }

        public void RefreshDataGridView()
        {
            List<Product> products = GetProductList();
            LoadDataGridView(products);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
