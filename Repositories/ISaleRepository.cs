using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISaleRepository
    {
        List<Sale> GetSale();

        Sale GetSalebyId(int id);

        void UpdateSale(int id, Sale sale);

        void AddSale(Sale sale);

        void DeleteSale(int id);
    }
}
