using System;
using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class OrderBUS
    {
        public static List<Order> GetAll()
        {
            return OrderDAO.SelectAll();
        }

        public static List<Order> GetAllByMonth(int month)
        {
            return OrderDAO.SelectAllByMonth(month);
        }

        public static List<Order> GetAllBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return OrderDAO.SelectAllBetweenDate(dateStart, dateEnd);
        }

        public static bool AddNew(Order newOrder)
        {
            return OrderDAO.Insert(newOrder);
        }
    }
}