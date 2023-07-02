using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ItechnicalRepository
    {
        List<Technical> GetTechical();

        Technical GetTechincalbyId(int id);

        void UpdateTechnical(int id, Technical technical);

        void AddTechnical(Technical technical);

        void DeleteTechnical(int id);
    }
}
