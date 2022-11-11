using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CategoryDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public static List<Category> SelectAll()
        {
            try
            {
                return db.Categories.ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Category> SelectAllByParentID(int parentId)
        {
            try
            {
                return db.Categories.Where(c => c.parent_id == parentId).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
