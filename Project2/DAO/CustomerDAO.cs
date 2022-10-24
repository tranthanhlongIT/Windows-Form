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
    }
}
