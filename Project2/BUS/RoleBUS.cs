using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class RoleBUS
    {
        public static List<Role> GetAll()
        {
            return RoleDAO.SelectAll();
        }
    }
}
