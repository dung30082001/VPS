using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomer()
        {
            var listCustomers = new List<Customer>();
            try
            {
                using (var context = new VPSContext())
                {
                    listCustomers = context.Customers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCustomers;
        }
        public static List<Customer> Get8Customer()
        {
            var listCustomers = new List<Customer>();
            try
            {
                using (var context = new VPSContext())
                {
                    listCustomers = context.Customers.OrderBy(x=>x.CustomerId).Take(8).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCustomers;
        }
        public static Customer GetCustomerById(int id)
        {
            var cus = new Customer();
            try
            {
                using (var context = new VPSContext())
                {
                    cus = context.Customers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return cus;
        }

        public static int GetTotalCus()
        {
            int finalCus;
            var listC = new List<Customer>();
            try
            {
                using (var context = new VPSContext())
                {
                    listC = context.Customers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalCus = listC.Count;
            return finalCus;
        }
        public static void UpdateCus(int id, Customer cus)
        {
            Customer current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Customers.Find(id);
                    current.FullName = cus.FullName;
                    current.Phone = cus.Phone;
                    current.Address = cus.Address;
                    current.Balance = cus.Balance;
                    current.Dob = cus.Dob;
                    current.StatusId = cus.StatusId;
                    current.Avatar = cus.Avatar;
                    current.IsValid = cus.IsValid;
                    context.Customers.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddCus(Customer cus)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Customers.Add(cus);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteCus(int id)
        {
            Customer current;
            try
            {
                RentDAO.DeleteRentByCusId(id);
                OrderDAO.DeleteOdByCusId(id);
                using (var context = new VPSContext())
                {
                    current = context.Customers.Find(id);
                    context.Customers.Remove(current);
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
