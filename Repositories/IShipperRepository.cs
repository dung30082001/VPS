using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IShipperRepository
    {
        List<Shipper> GetShipper();

        Shipper GetShipperbyId(int id);

        void UpdateShipper(int id, Shipper shipper);

        void AddShipper(Shipper shipper);

        void DeleteShipper(int id);
    }
}
