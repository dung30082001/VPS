using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RentDAO
    {
        public static List<Rent> GetRent()
        {
            var listRent = new List<Rent>();
            try
            {
                using (var context = new VPSContext())
                {
                    listRent = context.Rents.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listRent;
        }
        public static Rent GetRentById(int id)
        {
            var rent = new Rent();
            try
            {
                using (var context = new VPSContext())
                {
                    rent = context.Rents.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rent;
        }
        public static int GetRentByCustomerId(int id)
        {
            int cusId; ;
            try
            {
                using (var context = new VPSContext())
                {
                    cusId = context.Rents.FirstOrDefault(x=>x.OrderId==id).CustomerId;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return cusId;
        }
        public static void UpdateRent(int id, Rent rent)
        {
            Rent current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Rents.Find(id);
                    current.OrderId = rent.OrderId;
                    current.CustomerId = rent.CustomerId;
                    context.Rents.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddRent(Rent rent)
        {
            Rent current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Rents.Add(rent);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteRent(int id)
        {
            Rent current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Rents.Find(id);
                    context.Rents.Remove(current);
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
