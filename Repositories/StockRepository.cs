using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StockRepository : IStockRepository
    {
        public void AddStock(Stock stock)
        {
            StockDAO.AddStock(stock);
        }

        public void DeleteStock(int id)
        {
            StockDAO.DeleteStock(id);
        }

        public List<Stock> GetStock()
        {
            return StockDAO.GetStock();
        }

        public Stock GetStockbyId(int id)
        {
            return StockDAO.GetStockById(id);
        }

        public void UpdateStock(int id, Stock stock)
        {
            StockDAO.UpdateStock(id, stock);
        }
    }
}
