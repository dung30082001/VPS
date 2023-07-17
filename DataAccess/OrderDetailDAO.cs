using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetail()
        {
            var listOrderD = new List<OrderDetail>();
            try
            {
                using (var context = new VPSContext())
                {
                    listOrderD = context.OrderDetails.Include(x=>x.Product).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrderD;
        }
        public static OrderDetail GetOrderDetailById(int id)
        {
            var od = new OrderDetail();
            try
            {
                using (var context = new VPSContext())
                {
                    od = context.OrderDetails.Include(x => x.Product).FirstOrDefault(x=>x.OrderDetailId==id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return od;
        }
        public static List<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            var listOrderD = new List<OrderDetail>();

            try
            {
                using (var context = new VPSContext())
                {
                    listOrderD = context.OrderDetails.Include(x => x.Product).Where(x=>x.OrderId==id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrderD;
        }
        public static double GetTotalOrderDetail()
        {
            double finalOd = 0;
            var listO = new List<OrderDetail>();
            try
            {
                using (var context = new VPSContext())
                {
                    listO = context.OrderDetails.ToList();
                    foreach (var item in listO)
                    {
                        finalOd += item.UnitPrice.Value;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return finalOd;
        }
        public static void UpdateOrderDetail(int id, OrderDetail od)
        {
            OrderDetail current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.OrderDetails.Find(id);
                    current.OrderId = od.OrderId;
                    current.ProductId = od.ProductId;
                    current.UnitPrice = od.UnitPrice;
                    current.Quantity = od.Quantity;
                    current.Discount = od.Discount;
                    context.OrderDetails.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddOrderDetail(OrderDetail od)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.OrderDetails.Add(od);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteOrderDetail(int id)
        {
            OrderDetail current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.OrderDetails.Find(id);
                    context.OrderDetails.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteOrderDetailByOrderId(int id)
        {
            List<OrderDetail> current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.OrderDetails.Where(x => x.OrderId == id).ToList();
                    context.OrderDetails.RemoveRange(current);
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

