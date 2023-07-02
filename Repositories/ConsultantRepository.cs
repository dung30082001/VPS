using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ConsultantRepository : IConsultantRepository
    {
        public void AddConsultant(Consultant consultant)
        {
            ConsultantDAO.AddConsultant(consultant);
        }

        public void DeleteConsultant(int id)
        {
            ConsultantDAO.DeleteConsultant(id);
        }

        public List<Consultant> GetConsultant()
        {
            return ConsultantDAO.GetConsultant();
        }

        public Consultant GetConsultantById(int id)
        {
            return ConsultantDAO.GetConsultantById(id);
        }

        public void UpdateConsultant(int id, Consultant consultant)
        {
            ConsultantDAO.UpdateConsultant(id, consultant);
        }
    }
}

