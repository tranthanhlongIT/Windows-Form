using System.Collections.Generic;
using Project2.DAO;

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

        public bool AddNew(Order newOrder)
        {
            return orderDAO.Insert(newOrder);
        }
    }
}