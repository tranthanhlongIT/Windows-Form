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

        public static List<Order> GetAllByMonthYear(int month, int year)
        {
            return OrderDAO.SelectAllByMonthYear(month, year);
        }

        public static List<Order> GetAllBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return OrderDAO.SelectAllBetweenDate(dateStart, dateEnd);
        }

        public static bool AddNew(Order newOrder)
        {
            return OrderDAO.Insert(newOrder);
        }

        public static double GetRevenuesInMonth()
        {
            return OrderDAO.SelectSumRevenueInMonth();
        }

        public static int GetTotalOrderInMonth()
        {
            return OrderDAO.SelectTotalOrderInMonth();
        }

        public static int GetTotalCarSoldInMonth()
        {
            return OrderDAO.SelectTotalCarSoldInMonth();
        }

    }
}