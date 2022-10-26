using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAO;

namespace Project2.BUS
{
    class CustomerBUS
    {
        private CustomerDAO custDAO;

        public CustomerBUS()
        {
            custDAO = new CustomerDAO();
        }

        public List<Customer> GetAll()
        {
            return custDAO.SelectAll();
        }

        public Customer GetCustomerByID(int id)
        {
            return custDAO.SelectAllByID(id);
        }

        public bool AddNew(Customer newCustomer)
        {
            return custDAO.Insert(newCustomer);
        }

        public bool Update(Customer newCustomer)
        {
            return custDAO.Update(newCustomer);
        }

        public bool Disable(int id)
        {
            return custDAO.Disable(id);
        }
    }
}
