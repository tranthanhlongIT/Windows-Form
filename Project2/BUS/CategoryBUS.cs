using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAO;

namespace Project2.BUS
{
    class CategoryBUS
    {
        private CategoryDAO cateDAO = new CategoryDAO();

        public List<Category> GetAll()
        {
            List<Category> categories = cateDAO.SelectAll();
            return categories;
        }

        public List<Category> GetCategoryByParentID(int parentId)
        {
            List<Category> categories = cateDAO.SelectWithParentID(parentId);
            return categories;
        }
    }
}
