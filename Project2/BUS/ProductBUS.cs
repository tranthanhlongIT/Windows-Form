using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAO;

namespace Project2.BUS
{
    class ProductBUS
    {
        private ProductDAO prodDAO;

        public ProductBUS()
        {
            prodDAO = new ProductDAO();
        }

        public List<Product> GetAll()
        {
            return prodDAO.SelectAll();
        }

        public bool AddNew(Product newProduct)
        {
            return prodDAO.Insert(newProduct);
        }

        public bool Update(Product newProduct)
        {
            return prodDAO.Update(newProduct);
        }

        //public string GetProductType(int id)
        //{
        //    string type = prodDAO.SelectTypeByID(id);
        //    return type;
        //}

        //public string GetProductBrand(int id)
        //{
        //    string brand = prodDAO.SelectBrandByID(id);
        //    return brand;
        //}

        public Product GetProductByID(int id)
        {
            return prodDAO.SelectAllByID(id);
        }

        public List<Product> GetProductByBrandID(int categoryId)
        {
            return prodDAO.SelectAllByBrandID(categoryId);
        }

        public List<Product> GetProductByTypeID(int categoryId)
        {
            return prodDAO.SelectAllByTypeID(categoryId);
        }

        public List<Product> GetProductByTreeLevel(int level, int categoryId)
        {
            switch (level)
            {
                case 0: return GetAll();
                case 1: return GetProductByTypeID(categoryId);
                case 2: return GetProductByBrandID(categoryId);
                default: return null;
            }
        }

        public bool Delete(int id)
        {
            return prodDAO.Delete(id);
        }
    }
}
