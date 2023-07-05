using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrder();

        List<Order> GetOrderBySaleId(int id);

        List<Order> GetOrderByDate(string from,string to);

        Order GetOrderById(int id);

        int GetTotalOrder();

        void UpdateOrder(int id, Order od);

        void AddOrder(Order od);

        void DeleteOrder(int id);
    }
}
