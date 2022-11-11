using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CityDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<City> SelectAll()
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
