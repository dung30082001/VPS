using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SaleRepository : ISaleRepository
    {
        public void AddSale(Sale sale)
        {
            SaleDAO.AddSale(sale);
        }

        public void DeleteSale(int id)
        {
            SaleDAO.DeleteSale(id);
        }

        public List<Sale> GetSale()
        {
            return SaleDAO.GetSale();
        }

        public Sale GetSalebyId(int id)
        {
            return SaleDAO.GetSaleById(id);
        }

        public void UpdateSale(int id, Sale sale)
        {
            SaleDAO.UpdateSale(id, sale);
        }
    }
}
