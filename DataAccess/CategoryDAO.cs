using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        public static List<Category> GetCategory()
        {
            var listCategories = new List<Category>();
            try
            {
                using (var context = new VPSContext())
                {
                    listCategories = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCategories;
        }
        public static Category GetCategoryById(int id)
        {
            var category = new Category();
            try
            {
                using (var context = new VPSContext())
                {
                    category = context.Categories.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return category;
        }
        public static int GetTotalCategory()
        {
            int finalCategory;
            var listC = new List<Category>();
            try
            {
                using (var context = new VPSContext())
                {
                    listC = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalCategory = listC.Count;
            return finalCategory;
        }
        public static void UpdateCategory(int id, Category category)
        {
            Category current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Categories.Find(id);
                    current.CategoryName = category.CategoryName;
                    current.Description = category.Description;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddCategory(Category category)
        {
            Account current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteCategory(int id)
        {
            Category current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Categories.Find(id);
                    context.Categories.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
