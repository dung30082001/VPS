using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BloggerDAO
    {
        public static List<Blogger> GetBlogger()
        {
            var listBlogger = new List<Blogger>();
            try
            {
                using (var context = new VPSContext())
                {
                    listBlogger = context.Bloggers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listBlogger;
        }
        public static Blogger GetBloggerById(int id)
        {
            var blogger = new Blogger();
            try
            {
                using (var context = new VPSContext())
                {
                    blogger = context.Bloggers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return blogger;
        }
        public static void UpdateBlogger(int id, Blogger blogger)
        {
            Blogger current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Bloggers.Find(id);
                    current.FullName = blogger.FullName;
                    current.Phone = blogger.Phone;
                    current.Address = blogger.Address;
                    current.Dob = blogger.Dob;
                    current.StatusId = blogger.StatusId;
                    current.BlogId = blogger.BlogId;
                    context.Bloggers.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddBlogger(Blogger blogger)
        {
            Account current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Bloggers.Add(blogger);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteBlogger(int id)
        {
            Blogger current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Bloggers.Find(id);
                    context.Bloggers.Remove(current);
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
