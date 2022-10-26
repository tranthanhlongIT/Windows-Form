using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CustomerDAO
    {
        MyDBDataContext db;

        public CustomerDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<Customer> SelectAll()
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

        public Customer SelectAllByID(int id)
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

        public bool Insert(Customer newCustomer)
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

        public bool Update(Customer newCustomer)
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
                    dbCustomer.created_at = newCustomer.created_at;
                    dbCustomer.updated_at = newCustomer.updated_at;
                    dbCustomer.city_id = newCustomer.city_id;
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

        public bool Disable(int id)
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
