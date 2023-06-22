using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public void AddBlog(Blog blog)
        {
            BlogDAO.AddBlog(blog);
        }

        public void DeleteBlog(int id)
        {
            BlogDAO.DeleteBlog(id); 
        }

        public List<Blog> GetBlog()
        {
            return BlogDAO.GetBlog();
        }

        public Blog GetBlogById(int id)
        {
            return BlogDAO.GetBlogById(id);
        }

        public int GetTotalBlog()
        {
            return BlogDAO.GetTotalBlog();
        }

        public void UpdateBlog(int id, Blog blog)
        {
            BlogDAO.UpdateBlog(id, blog);
        }
    }
}
