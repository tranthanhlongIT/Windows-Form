using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project2.BUS;
using Project2.Forms.Components;

namespace Project2.UserControls
{
    public partial class ProductForm : UserControl
    {
        private List<Product> products;
        private List<Category> categories;
        private int id;
        private bool isEnabled = false;

        public ProductForm()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                LoadTreeView();
                LoadSearchTextBox();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by car name"))
            {
                txtSearch.Text = string.Empty;
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
            LoadDataGridView(products);
        }

        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvCategory.SelectedNode.SelectedImageIndex = tvCategory.SelectedNode.ImageIndex;
            if (isEnabled)
                RefreshDataGridView();
        }

        private void tvCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenModal("add", -99);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                id = (Int32)dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value;
                OpenModal("upd", id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                id = (Int32)dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value;
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool result = ProductBUS.Delete(id);
                    if (result)
                    {
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isEnabled = true;
            RefreshDataGridView();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                id = (Int32)dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value;
                OpenModal("det", id);
            }
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

        private List<Product> GetProductList()
        {
            int level = tvCategory.SelectedNode.Level;
            int categoryId = (int)tvCategory.SelectedNode.Tag;
            return ProductBUS.GetProductByTreeLevel(level, categoryId);
        }

        private void LoadDataGridView(List<Product> products)
        {
            dgvProduct.Rows.Clear();
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    dgvProduct.Rows.Add(product.id,
                                        product.name,
                                        product.price,
                                        product.discount,
                                        product.quantity,
                                        product.Category.name,
                                        product.Category1.name,
                                        SetAvailableField(product));
                }
            }
        }

        private void RefreshDataGridView()
        {
            products = GetProductList();
            LoadDataGridView(products);
        }

        private string SetAvailableField(Product product)
        {
            if (product.available)
                return "Yes";
            else return "No";
        }

        private void CreateParentNode(int parentId)
        {
            categories = CategoryBUS.GetCategoryByParentID(parentId);
            if (categories.Count > 0)
            {
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
        }

        private void CreateChildNode(TreeNode parentNode, int parentId)
        {
            categories = CategoryBUS.GetCategoryByParentID(parentId);
            if (categories != null)
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

        private void OpenModal(string action, int id)
        {
            Form formBackground = new Form();
            try
            {
                using (ProductModalForm uu = new ProductModalForm(action, id))
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
                if (action != "det")
                {
                    RefreshDataGridView();
                }
                formBackground.Dispose();
            }
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
    }
}