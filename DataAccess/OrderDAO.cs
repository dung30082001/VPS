﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    listOrder = context.Orders.ToList();
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
                    current.Status = od.Status;
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
    }
}