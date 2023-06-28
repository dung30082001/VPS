using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category category)
        {
        CategoryDAO.AddCategory(category);
        }

        public void DeleteCategory(int id)
        {
        CategoryDAO.DeleteCategory(id);
        }

        public List<Category> GetCategory()
        {
        return CategoryDAO.GetCategory();
        }

        public Category GetCategoryById(int id)
        {
            return CategoryDAO.GetCategoryById(id);
        }

        public int GetTotalCategory()
        {
            return CategoryDAO.GetTotalCategory();
        }

        public void UpdateCategory(int id, Category category)
        {
         CategoryDAO.UpdateCategory(id, category);
        }
    }
}
