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
    }
}
