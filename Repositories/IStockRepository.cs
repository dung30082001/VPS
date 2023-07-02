using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStockRepository
    {
        List<Stock> GetStock();

        Stock GetStockbyId(int id);

        void UpdateStock(int id, Stock stock);

        void AddStock(Stock stock);

        void DeleteStock(int id);
    }
}
