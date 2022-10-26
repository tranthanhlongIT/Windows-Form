using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CityDAO
    {
        MyDBDataContext db;

        public CityDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<City> SelectAll()
        {
            try
            {
                return db.Cities.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
