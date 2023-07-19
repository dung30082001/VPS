using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrder()
        {
            var listOrder = new List<Order>();
            try
            {
                using (var context = new VPSContext())
                {
                    listOrder = context.Orders.Include(m => m.Customer).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }

        public static List<Order> GetOrderBySaleId(int id)
        {
            var listOrder = new List<Order>();
            try
            {
                using (var context = new VPSContext())
                {
                    listOrder = context.Orders.Where(x=>x.SaleId==id).Include(m => m.Customer).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }
        public static List<Order> GetOrderByShipId(int id)
        {
            var listOrder = new List<Order>();
            try
            {
                using (var context = new VPSContext())
                {
                    listOrder = context.Orders.Where(x=>x.ShipId==id).Include(m => m.Ship).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }
        public static List<Order> GetOrderByDate(String from,String to)
        {
            var listOrder = new List<Order>();
            try
            {
                using (var context = new VPSContext())
                {
                    listOrder = context.Orders.Where(x=>x.OrderDate>Convert.ToDateTime(from) && x.OrderDate<Convert.ToDateTime(to)).Include(x => x.Customer).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }
        public static Order GetOrderById(int id)
        {
            var od = new Order();
            try
            {
                using (var context = new VPSContext())
                {
                    od = context.Orders.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return od;
        }
        public static int GetTotalOrder()
        {
            int finalOd;
            var listO = new List<Order>();
            try
            {
                using (var context = new VPSContext())
                {
                    listO = context.Orders.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalOd = listO.Count;
            return finalOd;
        }
        public static void UpdateOd(int id, Order od)
        {
            Order current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Orders.Find(id);
                    current.SaleId = od.SaleId;
                    current.CustomerId = od.CustomerId;
                    current.OrderDate = od.OrderDate;
                    current.ShippedDate = od.ShippedDate;
                    current.ShipId = od.ShipId;
                    current.Price = od.Price;
                    current.StatusId = od.StatusId;
                    current.ShipCost = od.ShipCost;
                    current.ManagerConfirm = od.ManagerConfirm;
                    current.SaleConfirm = od.SaleConfirm;
                    current.ShipConfirm = od.ShipConfirm;
                    current.CustomerConfirm = od.CustomerConfirm;
                    context.Orders.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddOrder(Order od)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Orders.Add(od);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteOd(int id)
        {
            Order current;
            try
            {
                RentDAO.DeleteRentByOrId(id);
                OrderDetailDAO.DeleteOrderDetailByOrderId(id);
                using (var context = new VPSContext())
                {
                    current = context.Orders.Find(id);
                    context.Orders.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteOdByCusId(int id)
        {
            var listO = new List<Order>();
            try
            {
                RentDAO.DeleteRentByOrId(id);
                OrderDetailDAO.DeleteOrderDetailByOrderId(id);
                using (var context = new VPSContext())
                {
                    listO = context.Orders.Where(x => x.CustomerId == id).ToList();
                    context.Orders.RemoveRange(listO);
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
