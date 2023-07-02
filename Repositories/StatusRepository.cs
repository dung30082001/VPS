using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StatusRepository : IStatusRepository
    {
        public void AddStatus(Status status)
        {
            StatusDAO.AddStatus(status);
        }

        public void DeleteStatus(int id)
        {
            StatusDAO.DeleteStatus(id);
        }

        public List<Status> GetStatus()
        {
            return StatusDAO.GetStatus();
        }

        public Status GetStatusbyId(int id)
        {
            return StatusDAO.GetStatusrById(id);
        }

        public void UpdateStatus(int id, Status status)
        {
            StatusDAO.UpdateStatus(id, status);
        }
    }
}
