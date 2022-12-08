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

        public static List<Order> SelectAllByMonthYear(int month, int year)
        {
            try
            {
                return db.Orders.Where(o => o.created_at.Month == month && o.created_at.Year == year).ToList();
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
                return db.Orders.Where(o => o.created_at.Date >= dateStart.Date && o.created_at.Date <= dateEnd.Date).ToList();
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

        public static double SelectSumRevenueInMonth()
        {
            try
            {
                return db.Orders.Where(o => o.created_at.Month == DateTime.Now.Month).Sum(o => o.total);
            }
            catch
            {
                return 0;
            }
        }
    }
}