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

        public List<Product> GetProductByCategoryID(int categoryID)
        {
            List<Product> products = prodDAO.SelectWithCategoryID(categoryID);
            return products;
        }
    }
}
