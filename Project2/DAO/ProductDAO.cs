using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class ProductDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<Product> SelectAll()
        {
            try
            {
                return db.Products.Where(p => p.deleted_at == null).ToList();
            }
            catch
            {
                return null;
            }
        }  

        public static List<Product> SelectAllAvailableProduct()
        {
            try
            {
                return db.Products.Where(p => p.available && p.deleted_at == null).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Product> SelectAllAvailableProductByTypeID(int categoryId)
        {
            try
            {
                return db.Products.Where(p => p.available && p.deleted_at == null && p.type_id == categoryId).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static Product SelectAllByID(int id)
        {
            try
            {
                return db.Products.SingleOrDefault(p => p.id == id);
            }
            catch
            {
                return null;
            }
        }

        public static List<Product> SelectAllByTypeID(int typeId)
        {
            try
            {
                return db.Products.Where(p => p.type_id == typeId && p.deleted_at == null).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Product> SelectAllByBrandID(int brandId)
        {
            try
            {
                return db.Products.Where(p => p.brand_id == brandId && p.deleted_at == null).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static bool Insert(Product newProduct)
        {
            try
            {
                db.Products.InsertOnSubmit(newProduct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Product newProduct)
        {
            Product dbProduct = db.Products.SingleOrDefault(p => p.id == newProduct.id);
            if (dbProduct != null)
            {
                try
                {
                    dbProduct.name = newProduct.name;
                    dbProduct.description = newProduct.description;
                    dbProduct.price = newProduct.price;
                    dbProduct.discount = newProduct.discount;
                    dbProduct.quantity = newProduct.quantity;
                    dbProduct.available = newProduct.available;
                    dbProduct.image = newProduct.image;
                    dbProduct.updated_at = DateTime.Now;
                    dbProduct.Category = db.Categories.SingleOrDefault(c => c.id == newProduct.type_id);
                    dbProduct.Category1 = db.Categories.SingleOrDefault(c => c.id == newProduct.brand_id);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool Delete(int id)
        {
            Product dbProduct = db.Products.SingleOrDefault(c => c.id == id);
            if (dbProduct != null)
            {
                try
                {
                    dbProduct.deleted_at = DateTime.Now;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}