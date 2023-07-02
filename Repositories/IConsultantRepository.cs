using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IConsultantRepository
    {
        List<Consultant> GetConsultant();

        Consultant GetConsultantById(int id);

        void UpdateConsultant(int id, Consultant consultant);

        void AddConsultant(Consultant consultant);

        void DeleteConsultant(int id);
    }
}
