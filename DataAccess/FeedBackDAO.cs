using BusinessObject.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FeedBackDAO
    {
        public static List<FeedBack> GetFeedBack()
        {
            var listFeedback = new List<FeedBack>();
            try
            {
                using (var context = new VPSContext())
                {
                    listFeedback = context.FeedBacks.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listFeedback;
        }
        public static FeedBack GetFeedBackById(int id)
        {
            var feedback = new FeedBack();
            try
            {
                using (var context = new VPSContext())
                {
                    feedback = context.FeedBacks.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return feedback;
        }
        public static void UpdateFeedBack(int id, FeedBack feedback)
        {
            FeedBack current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.FeedBacks.Find(id);
                    current.CustomerId = feedback.CustomerId;
                    current.ShipperId = feedback.ShipperId;
                    current.ConsultantId = feedback.ConsultantId;
                    current.OrderId = feedback.OrderId;
                    current.Content = feedback.Content;
                    context.FeedBacks.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddFeedBack(FeedBack feedBack)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.FeedBacks.Add(feedBack);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteFeedBack(int id)
        {
            FeedBack current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.FeedBacks.Find(id);
                    context.FeedBacks.Remove(current);
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
