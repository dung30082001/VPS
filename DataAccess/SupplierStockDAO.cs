using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierStockDAO
    {
        public static List<SupplierStock> GetSupplierStock()
        {
            var listSupplierStock = new List<SupplierStock>();
            try
            {
                using (var context = new VPSContext())
                {
                    listSupplierStock = context.SupplierStocks.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSupplierStock;
        }
        public static SupplierStock GetSupplierStockById(int id)
        {
            var supplierStock = new SupplierStock();
            try
            {
                using (var context = new VPSContext())
                {
                    supplierStock = context.SupplierStocks.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return supplierStock;
        }
        public static void UpdateSupplierStock(int id, SupplierStock supplierStock)
        {
            SupplierStock current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.SupplierStocks.Find(id);
                    current.ProductId = supplierStock.ProductId;
                    current.SupplierId = supplierStock.SupplierId;
                    current.CategoryId = supplierStock.CategoryId;
                    context.SupplierStocks.Update(supplierStock);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddSupplierStock(SupplierStock supplierStock)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.SupplierStocks.Add(supplierStock);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteSupplierStock(int id)
        {
            SupplierStock current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.SupplierStocks.Find(id);
                    context.SupplierStocks.Remove(current);
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
