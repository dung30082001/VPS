using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RentRepository : IRentRepository
    {
        public void AddRent(Rent rent)
        {
            RentDAO.AddRent(rent);
        }

        public void DeleteRent(int id)
        {
            RentDAO.DeleteRent(id);
        }

        public int GetCusByOrderId(int id)
        {
            return RentDAO.GetRentByCustomerId(id);
        }

        public List<Rent> GetRent()
        {
            return RentDAO.GetRent();
        }

        public Rent GetRentbyId(int id)
        {
            return RentDAO.GetRentById(id);
        }

        public void UpdateRent(int id, Rent rent)
        {
            RentDAO.UpdateRent(id, rent);
        }
    }
}
