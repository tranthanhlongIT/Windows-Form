using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project2.DAO
{
    class CategoryDAO
    {
        MyDBDataContext db;

        public CategoryDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<Category> SelectAll()
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

        public List<Category> SelectAllByParentID(int parentId)
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

        //public Category SelectAllById(int id)
        //{
        //    try
        //    {
        //        return db.Categories.SingleOrDefault(c => c.id == id);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
            
        //}

        //public List<Category> SelectSubCategory(int parentId)
        //{
        //    try
        //    {
        //        var mainCategoryList = db.Categories.Where(c => c.parent_id == parentId).Select(c => c.id).ToList();
        //        List<Category> subCategories = db.Categories.Where(c => mainCategoryList.Contains(c.id)).ToList();
        //        return subCategories;
        //    }
        //    catch
        //    {
        //        return null;
        //    }   
        //}
    }
}
