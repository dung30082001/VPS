using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail od)
        {
            OrderDetailDAO.AddOrderDetail(od);
        }

        public void DeleteOrderDetail(int id)
        {
            OrderDetailDAO.DeleteOrderDetail(id);
        }

        public List<OrderDetail> GetOrderDetail()
        {
            return OrderDetailDAO.GetOrderDetail();
        }

        public OrderDetail GetOrderDetailById(int id)
        {
            return OrderDetailDAO.GetOrderDetailById(id);
        }

        public List<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            return OrderDetailDAO.GetOrderDetailByOrderId(id);
        }

        public double GetTotalOrderDetail()
        {
            return OrderDetailDAO.GetTotalOrderDetail();
        }

        public void UpdateOrderDetail(int id, OrderDetail od)
        {
            OrderDetailDAO.UpdateOrderDetail(id,od);
        }
    }
}
