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
        private ProductDAO prodDAO = new ProductDAO();

        public List<Product> GetAll()
        {
            List<Product> products = prodDAO.SelectAll();
            return products;
        }

        public bool AddNew(Product newProduct)
        {
            bool result = prodDAO.Insert(newProduct);
            return result;
        }

        public bool Update(Product newProduct)
        {
            bool result = prodDAO.Update(newProduct);
            return result;
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
            Product product = prodDAO.SelectAllByID(id);
            return product;
        }

        public List<Product> GetProductByBrandID(int categoryId)
        {
            List<Product> products = prodDAO.SelectAllByBrandID(categoryId);
            return products;
        }

        public List<Product> GetProductByTypeID(int categoryId)
        {
            List<Product> products = prodDAO.SelectAllByTypeID(categoryId);
            return products;
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
            bool result = prodDAO.Delete(id);
            return result;
        }
    }
}
