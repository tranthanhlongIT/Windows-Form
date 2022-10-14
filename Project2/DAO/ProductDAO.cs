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

        public List<Product> SelectWithCategoryID(int categoryID)
        {
            try
            {
                List<Product> products = db.Products.Where(p => p.category_id == categoryID).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }
    }
}