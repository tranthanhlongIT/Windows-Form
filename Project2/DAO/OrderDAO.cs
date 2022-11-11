using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class OrderDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<Order> SelectAll()
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

        public static List<Order> SelectAllBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            try
            {
                if (dateStart.Date == dateEnd.Date)
                    return db.Orders.Where(o => o.created_at >= dateStart && o.created_at <= dateEnd.AddDays(1)).ToList();
                else return db.Orders.Where(o => o.created_at >= dateStart && o.created_at <= dateEnd).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static bool Insert(Order newOrder)
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