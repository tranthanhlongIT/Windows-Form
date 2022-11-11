using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class ProductBUS
    {
        public static List<Product> GetAll()
        {
            return ProductDAO.SelectAll();
        }

        public static bool AddNew(Product newProduct)
        {
            return ProductDAO.Insert(newProduct);
        }

        public static bool Update(Product newProduct)
        {
            return ProductDAO.Update(newProduct);
        }

        public static Product GetProductByID(int id)
        {
            return ProductDAO.SelectAllByID(id);
        }

        public static List<Product> GetProductByBrandID(int categoryId)
        {
            return ProductDAO.SelectAllByBrandID(categoryId);
        }

        public static List<Product> GetProductByTypeID(int categoryId)
        {
            return ProductDAO.SelectAllByTypeID(categoryId);
        }

        public static List<Product> GetProductByTreeLevel(int level, int categoryId)
        {
            switch (level)
            {
                case 0: return GetAll();
                case 1: return GetProductByTypeID(categoryId);
                case 2: return GetProductByBrandID(categoryId);
                default: return null;
            }
        }

        public static bool Delete(int id)
        {
            return ProductDAO.Delete(id);
        }
    }
}
