using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBlogRepository
    {
        List<Blog> GetBlog();

        Blog GetBlogById(int id);

        int GetTotalBlog();

        void UpdateBlog(int id, Blog blog);

        void AddBlog(Blog blog);

        void DeleteBlog(int id);
    }
}
