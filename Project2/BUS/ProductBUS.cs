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

        public List<Product> GetProductByCategoryID(int categoryId)
        {
            List<Product> products = prodDAO.SelectWithCategoryID(categoryId);
            return products;
        }

        public List<Product> GetProductByMainCategory(int categoryId)
        {
            List<Product> products = prodDAO.SelectWithMainCategory(categoryId);
            return products;
        }

        public List<Product> GetProductByTreeLevel(int level, int categoryId)
        {
            switch (level)
            {
                case 0: return GetAll();
                case 1: return GetProductByMainCategory(categoryId);
                case 2: return GetProductByCategoryID(categoryId);
                default: return null;
            }
        }
    }
}
