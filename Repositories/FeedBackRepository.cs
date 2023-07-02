using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FeedBackRepository : IFeedBackRepository
    {
        public void AddFeedBack(FeedBack feedBack)
        {
            FeedBackDAO.AddFeedBack(feedBack);
        }

        public void DeleteFeedBack(int id)
        {
           FeedBackDAO.DeleteFeedBack(id);
        }

        public List<FeedBack> GetFeedBack()
        {
            return FeedBackDAO.GetFeedBack();
        }

        public FeedBack GetFeedBackbyId(int id)
        {
            return FeedBackDAO.GetFeedBackById(id);
        }

        public void UpdateFeedBack(int id, FeedBack feedBack)
        {
            FeedBackDAO.UpdateFeedBack(id, feedBack);
        }
    }
}
