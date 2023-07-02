using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStatusRepository
    {
        List<Status> GetStatus();

        Status GetStatusbyId(int id);

        void UpdateStatus(int id, Status status);

        void AddStatus(Status status);

        void DeleteStatus(int id);
    }
}
