using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StockDAO
    {
        public static List<Stock> GetStock()
        {
            var listStock = new List<Stock>();
            try
            {
                using (var context = new VPSContext())
                {
                    listStock = context.Stocks.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listStock;
        }
        public static Stock GetStockById(int id)
        {
            var stock = new Stock();
            try
            {
                using (var context = new VPSContext())
                {
                    stock = context.Stocks.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return stock;
        }
        public static void UpdateStock(int id, Stock stock)
        {
            Stock current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Stocks.Find(id);
                    current.ProductId = stock.ProductId;
                    current.TechnicalId = stock.TechnicalId;
                    current.SupplierId = stock.SupplierId;
                    current.CategoryId = stock.CategoryId;
                    context.Stocks.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddStock(Stock stock)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Stocks.Add(stock);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteStock(int id)
        {
            Stock current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Stocks.Find(id);
                    context.Stocks.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
