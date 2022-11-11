using System.Collections.Generic;
using Project2.DAO;

namespace Project2.BUS
{
    class CategoryBUS
    {
        public static List<Category> GetAll()
        {
            return CategoryDAO.SelectAll();
        }

        public static List<Category> GetCategoryByParentID(int parentId)
        {
            return CategoryDAO.SelectAllByParentID(parentId);
        }
    }
}
