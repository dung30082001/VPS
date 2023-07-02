using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SaleDAO
    {
        public static List<Sale> GetSale()
        {
            var listSale = new List<Sale>();
            try
            {
                using (var context = new VPSContext())
                {
                    listSale = context.Sales.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSale;
        }
        public static Sale GetSaleById(int id)
        {
            var sale = new Sale();
            try
            {
                using (var context = new VPSContext())
                {
                    sale = context.Sales.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return sale;
        }
        public static void UpdateSale(int id, Sale sale)
        {
            Sale current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Sales.Find(id);
                    current.FullName = sale.FullName;
                    current.Phone = sale.Phone;
                    current.Address = sale.Address;
                    current.Dob = sale.Dob;
                    current.OrderId = sale.OrderId;
                    current.StatusId = sale.StatusId;
                    current.ShipperId = sale.ShipperId;
                    current.CustomerId = sale.CustomerId;
                    current.Avatar = sale.Avatar;
                    context.Sales.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddSale(Sale sale)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Sales.Add(sale);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteSale(int id)
        {
            Sale current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Sales.Find(id);
                    context.Sales.Remove(current);
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

