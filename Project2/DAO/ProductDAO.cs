using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project2.DAO
{
    class ProductDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Product> SelectAll()
        {
            try
            {
                List<Product> products = db.Products.ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }  

        public List<Product> SelectWithCategoryID(int categoryId)
        {
            try
            {
                List<Product> products = db.Products.Where(p => p.category_id == categoryId).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<Product> SelectWithMainCategory(int categoryId)
        {
            try
            {
                var mainCategoryList = db.Categories.Where(c => c.parent_id == categoryId).Select(c => c.id).ToList();
                var subCategoryList = db.Categories.Where(c => mainCategoryList.Contains(c.id)).Select(c => c.id).ToList();
                List<Product> products = db.Products.Where(p => subCategoryList.Contains((int)p.category_id)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }
    }
}