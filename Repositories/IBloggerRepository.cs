using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBloggerRepository
    {
        List<Blogger> GetBlogger();

        Blogger GetBloggerById(int id);

        void UpdateBlogger(int id, Blogger blogger);

        void AddBlogger(Blogger blogger);

        void DeleteBlogger(int id);
    }
}
