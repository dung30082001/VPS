using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierProductDAO
    {
        public static List<SupplierProduct> GetSupplierProduct()
        {
            var listSupplierProduct = new List<SupplierProduct>();
            try
            {
                using (var context = new VPSContext())
                {
                    listSupplierProduct = context.SupplierProducts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSupplierProduct;
        }
        public static SupplierProduct GetSupplierProductById(int id)
        {
            var supplierProduct = new SupplierProduct();
            try
            {
                using (var context = new VPSContext())
                {
                    supplierProduct = context.SupplierProducts.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return supplierProduct;
        }
        public static void UpdateSupplierProduct(int id, SupplierProduct supplierProduct)
        {
            SupplierProduct current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.SupplierProducts.Find(id);
                    current.ProductName = supplierProduct.ProductName;
                    current.Description = supplierProduct.Description;
                    current.CategoryId = supplierProduct.CategoryId;
                    current.Image = supplierProduct.Image;
                    current.Brand = supplierProduct.Brand;
                    current.UnitInStock = supplierProduct.UnitInStock;
                    current.UnitPrice = supplierProduct.UnitPrice;
                    current.NumberOfUse = supplierProduct.NumberOfUse;
                    context.SupplierProducts.Update(supplierProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddSupplierProduct(SupplierProduct supplierProduct)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.SupplierProducts.Add(supplierProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteSupplierProduct(int id)
        {
            SupplierProduct current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.SupplierProducts.Find(id);
                    context.SupplierProducts.Remove(current);
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
