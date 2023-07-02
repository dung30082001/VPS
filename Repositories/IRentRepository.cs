using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRentRepository
    {
        List<Rent> GetRent();

        Rent GetRentbyId(int id);

        int GetCusByOrderId(int id);

        void UpdateRent(int id, Rent rent);

        void AddRent(Rent rent);

        void DeleteRent(int id);
    }
}
