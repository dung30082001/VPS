using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order od)
        {
             OrderDAO.AddOrder(od);
        }

        public void DeleteOrder(int id)
        {
           OrderDAO.DeleteOd(id);
        }

        public List<Order> GetOrder()
        {
            return OrderDAO.GetOrder();
        }

        public List<Order> GetOrderByDate(string from,string to)
        {
            return OrderDAO.GetOrderByDate(from,to);
        }

        public Order GetOrderById(int id)
        {
            return OrderDAO.GetOrderById(id);
        }

        public List<Order> GetOrderBySaleId(int id)
        {
            return OrderDAO.GetOrderBySaleId(id);
        }

        public List<Order> GetOrderByShipId(int id)
        {
            return OrderDAO.GetOrderByShipId(id);
        }

        public int GetTotalOrder()
        {
            return OrderDAO.GetTotalOrder();
        }

        public void UpdateOrder(int id, Order od)
        {
            OrderDAO.UpdateOd(id, od);
        }
    }
}
