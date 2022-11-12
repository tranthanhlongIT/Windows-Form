using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CustomerDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<Customer> SelectAll()
        {
            try
            {
                return db.Customers.ToList();
            }
            catch
            {
                return null;
            }
        }

        public static Customer SelectAllByID(int id)
        {
            try
            {
                return db.Customers.SingleOrDefault(p => p.id == id);
            }
            catch
            {
                return null;
            }
        }

        public static bool Insert(Customer newCustomer)
        {
            try
            {
                db.Customers.InsertOnSubmit(newCustomer);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Customer newCustomer)
        {
            Customer dbCustomer = db.Customers.SingleOrDefault(c => c.id == newCustomer.id);
            if (dbCustomer != null)
            {
                try
                {
                    dbCustomer.fname = newCustomer.fname;
                    dbCustomer.lname = newCustomer.lname;
                    dbCustomer.gender = newCustomer.gender;
                    dbCustomer.address = newCustomer.address;
                    dbCustomer.phone = newCustomer.phone;
                    dbCustomer.zipcode = newCustomer.zipcode;
                    dbCustomer.is_active = newCustomer.is_active;
                    dbCustomer.city_id = newCustomer.city_id;
                    dbCustomer.updated_at = DateTime.Now;
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

        public static bool Disable(int id)
        {
            Customer dbCustomer = db.Customers.SingleOrDefault(c => c.id == id);
            if (dbCustomer != null)
            {
                try
                {
                    dbCustomer.is_active = false;
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
