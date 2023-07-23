using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShipperDAO
    {
        public static List<Shipper> GetShipper() 
        {
            var listShiper = new List<Shipper>();
            try
            {
                using (var context = new VPSContext())
                {
                    listShiper = context.Shippers.Include(x=>x.Status).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listShiper;
        }
        public static Shipper GetShipperById(int id)
        {
            var shipper = new Shipper();
            try
            {
                using (var context = new VPSContext())
                {
                    shipper = context.Shippers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return shipper;
        }
        public static void UpdateShipper(int id, Shipper shipper)
        {
            Shipper current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Shippers.Find(id);
                    current.FullName = shipper.FullName;
                    current.Phone = shipper.Phone;
                    current.Address = shipper.Address;
                    current.Dob = shipper.Dob;
                    current.StatusId = shipper.StatusId;
                    current.Avatar = shipper.Avatar;
                    context.Shippers.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddShipper(Shipper shipper)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Shippers.Add(shipper);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteShipper(int id)
        {
            Shipper current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Shippers.Find(id);
                    context.Shippers.Remove(current);
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
