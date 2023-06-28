using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategory();

        Category GetCategoryById(int id);

        int GetTotalCategory();

        void UpdateCategory(int id, Category category);

        void AddCategory(Category category);

        void DeleteCategory(int id);
    }
}
