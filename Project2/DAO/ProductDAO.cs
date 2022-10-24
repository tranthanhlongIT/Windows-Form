﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project2.DAO
{
    class ProductDAO
    {
        MyDBDataContext db;

        public ProductDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<Product> SelectAll()
        {
            try
            {
                return db.Products.ToList();
            }
            catch
            {
                return null;
            }
        }  

        public Product SelectAllByID(int id)
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

        public List<Product> SelectAllByTypeID(int typeId)
        {
            try
            {
                return db.Products.Where(p => p.type_id == typeId).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Product> SelectAllByBrandID(int brandId)
        {
            try
            {
                return db.Products.Where(p => p.brand_id == brandId).ToList();
            }
            catch
            {
                return null;
            }
        }

        //public string SelectTypeByID(int id)
        //{
        //    string type = (from p in db.Products
        //                   join c in db.Categories
        //                   on p.type_id equals c.id
        //                   where p.id == id
        //                   select c.name).SingleOrDefault();
        //    return type;
        //}

        //public string SelectBrandByID(int id)
        //{
        //    string brand = (from p in db.Products
        //                    join c in db.Categories
        //                    on p.brand_id equals c.id
        //                    where p.id == id
        //                    select c.name).SingleOrDefault();
        //    return brand;
        //}

        public bool Insert(Product newProduct)
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

        public bool Update(Product newProduct)
        {
            Product dbProduct = db.Products.SingleOrDefault(c => c.id == newProduct.id);
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
                    dbProduct.created_at = newProduct.created_at;
                    dbProduct.updated_at = newProduct.updated_at;
                    dbProduct.type_id = newProduct.type_id;
                    dbProduct.brand_id = newProduct.brand_id;
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

        public bool Delete(int id)
        {
            Product dbProduct = db.Products.SingleOrDefault(c => c.id == id);
            if (dbProduct != null)
            {
                try
                {
                    db.Products.DeleteOnSubmit(dbProduct);
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