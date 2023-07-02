using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ShipperRepository : IShipperRepository
    {
        public void AddShipper(Shipper shipper)
        {
            ShipperDAO.AddShipper(shipper);
        }

        public void DeleteShipper(int id)
        {
            ShipperDAO.DeleteShipper(id);
        }

        public List<Shipper> GetShipper()
        {
            return ShipperDAO.GetShipper();
        }

        public Shipper GetShipperbyId(int id)
        {
            return ShipperDAO.GetShipperById(id);
        }

        public void UpdateShipper(int id, Shipper shipper)
        {
            ShipperDAO.UpdateShipper(id, shipper);
        }
    }
}
