using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlogDAO
    {
        public static List<Blog> GetBlog()
        {
            var listBlogs = new List<Blog>();
            try
            {
                using (var context = new VPSContext())
                {
                    listBlogs = context.Blogs.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listBlogs;
        }
        public static Blog GetBlogById(int id)
        {
            var blog = new Blog();
            try
            {
                using (var context = new VPSContext())
                {
                    blog = context.Blogs.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return blog;
        }
        public static int GetTotalBlog()
        {
            int finalBlog;
            var listB = new List<Blog>();
            try
            {
                using (var context = new VPSContext())
                {
                    listB = context.Blogs.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalBlog = listB.Count;
            return finalBlog;
        }
        public static void UpdateBlog(int id, Blog blog)
        {
            Blog current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Blogs.Find(id);
                    current.BloggerId = blog.BloggerId;
                    current.Title = blog.Title;
                    current.Description = blog.Description;
                    current.PublishDate = blog.PublishDate;
                    current.ImageId = blog.ImageId;
                    current.StatusId = blog.StatusId;
                    context.Blogs.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddBlog(Blog blog)
        {
            Blog current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Blogs.Add(blog);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteBlog(int id)
        {
            Blog current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Blogs.Find(id);
                    context.Blogs.Remove(current);
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
