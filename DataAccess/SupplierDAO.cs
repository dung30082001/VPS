using BusinessObject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierDAO
    {
        public static List<Supplier> GetSupplier()
        {
            var listSupplier = new List<Supplier>();
            try
            {
                using (var context = new VPSContext())
                {
                    listSupplier = context.Suppliers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSupplier;
        }
        public static Supplier GetSupplierById(int id)
        {
            var supplier = new Supplier();
            try
            {
                using (var context = new VPSContext())
                {
                    supplier = context.Suppliers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return supplier;
        }
        public static void UpdateSupplier(int id, Supplier supplier)
        {
            Supplier current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Suppliers.Find(id);
                    current.SupplierName = supplier.SupplierName;
                    current.Phone = supplier.Phone;
                    current.Address = supplier.Address;
                    current.Dob = supplier.Dob;
                    current.Avatar = supplier.Avatar;
                    current.StatusId = supplier.StatusId;
                    context.Suppliers.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddSupplier(Supplier supplier)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Suppliers.Add(supplier);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteSupplier(int id)
        {
            Supplier current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Suppliers.Find(id);
                    context.Suppliers.Remove(current);
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
