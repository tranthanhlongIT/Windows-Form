using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class CityBUS
    {
        public static List<City> GetAll()
        {
            return CityDAO.SelectAll();
        }
    }
}