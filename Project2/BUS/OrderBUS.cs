using System;
using System.Collections.Generic;
using Project2.DAO;
using System.Linq;

namespace Project2.BUS
{
    class OrderBUS
    {
        private OrderDAO orderDAO;

        public OrderBUS()
        {
            orderDAO = new OrderDAO();
        }

        public List<Order> GetAll()
        {
            return orderDAO.SelectAll();
        }

        public List<Order> GetAllBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return orderDAO.SelectAllBetweenDate(dateStart, dateEnd);
        }

        public bool AddNew(Order newOrder)
        {
            return orderDAO.Insert(newOrder);
        }
    }
}