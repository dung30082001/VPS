using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BloggerRepository : IBloggerRepository
    {
        public void AddBlogger(Blogger blogger)
        {
            BloggerDAO.AddBlogger(blogger);
        }

        public void DeleteBlogger(int id)
        {
            BloggerDAO.DeleteBlogger(id);
        }

        public List<Blogger> GetBlogger()
        {
            return BloggerDAO.GetBlogger();
        }

        public Blogger GetBloggerById(int id)
        {
            return BloggerDAO.GetBloggerById(id);
        }

        public void UpdateBlogger(int id, Blogger blogger)
        {
            BloggerDAO.UpdateBlogger(id, blogger);
        }
    }
}
