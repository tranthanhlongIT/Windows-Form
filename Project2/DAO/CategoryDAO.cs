using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project2.DAO
{
    class CategoryDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Category> SelectAll()
        {
            try
            {
                List<Category> categories = db.Categories.ToList();
                return categories;
            }
            catch
            {
                return null;
            }
        }

        public List<Category> SelectWithParentID(int parentId)
        {
            try
            {
                List<Category> categories = db.Categories.Where(c => c.parent_id == parentId).ToList();
                return categories;
            }
            catch
            {
                return null;
            }
        }

    }
}
