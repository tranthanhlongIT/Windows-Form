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
        private CategoryDAO cateDAO;

        public CategoryBUS()
        {
            cateDAO = new CategoryDAO();
        }

        public List<Category> GetAll()
        {
            return cateDAO.SelectAll();
        }

        public List<Category> GetCategoryByParentID(int parentId)
        {
            return cateDAO.SelectAllByParentID(parentId); ;
        }
    }
}
