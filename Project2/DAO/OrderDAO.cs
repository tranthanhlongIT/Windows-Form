using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class OrderDAO
    {
        MyDBDataContext db;

        public OrderDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<Order> SelectAll()
        {
            try
            {
                return db.Orders.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Insert(Order newOrder)
        {
            try
            {
                db.Orders.InsertOnSubmit(newOrder);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}