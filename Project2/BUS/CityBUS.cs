using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAO;

namespace Project2.BUS
{
    class CityBUS
    {
        private CityDAO cityDAO;

        public CityBUS()
        {
            cityDAO = new CityDAO();
        }

        public List<City> GetAll()
        {
            return cityDAO.SelectAll();
        }
    }
}
