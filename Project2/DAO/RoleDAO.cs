using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class RoleDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<Role> SelectAll()
        {
            try
            {
                return db.Roles.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
