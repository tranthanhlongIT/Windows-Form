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
        public List<Product> GetAll()
        {
            List<Product> products = new ProductDAO().SelectAll();
            return products;
        }

        //public List<object> GetAllWithCategory()
        //{
        //    List<Product> listProduct = GetAll();
        //    List<object> listObj = new List<object>();
        //    foreach (var product in listProduct)
        //    {
        //        listObj.Add(new { id = product.id,
        //            name = product.name,
        //            description = product.description,

        //            category_name = product.Category.name });
        //    }
        //}
    }
}
