using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class CustomerBUS
    {
        public static List<Customer> GetAll()
        {
            return CustomerDAO.SelectAll();
        }

        public static Customer GetCustomerByID(int id)
        {
            return CustomerDAO.SelectAllByID(id);
        }

        public static bool AddNew(Customer newCustomer)
        {
            return CustomerDAO.Insert(newCustomer);
        }

        public static bool Update(Customer newCustomer)
        {
            return CustomerDAO.Update(newCustomer);
        }

        public static bool Disable(int id)
        {
            return CustomerDAO.Disable(id);
        }
    }
}
