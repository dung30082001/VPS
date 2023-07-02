using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TechnicalRepository : ItechnicalRepository
    {
        public void AddTechnical(Technical technical)
        {
            TechnicalDAO.AddTechnical(technical);
        }

        public void DeleteTechnical(int id)
        {
            TechnicalDAO.DeleteTechincal(id);
        }

        public List<Technical> GetTechical()
        {
            return TechnicalDAO.GetTechnical();
        }

        public Technical GetTechincalbyId(int id)
        {
            return TechnicalDAO.GetTechnicalById(id);
        }

        public void UpdateTechnical(int id, Technical technical)
        {
            TechnicalDAO.UpdateTechnical(id, technical);
        }
    }
}
