using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFeedBackRepository
    {
        List<FeedBack> GetFeedBack();

        FeedBack GetFeedBackbyId(int id);

        void UpdateFeedBack(int id, FeedBack feedBack);

        void AddFeedBack(FeedBack feedBack);

        void DeleteFeedBack(int id);
    }
}
