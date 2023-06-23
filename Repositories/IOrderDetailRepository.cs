using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetail();

        List<OrderDetail> GetOrderDetailByOrderId(int id);

        OrderDetail GetOrderDetailById(int id);

        double GetTotalOrderDetail();

        void UpdateOrderDetail(int id, OrderDetail od);

        void AddOrderDetail(OrderDetail od);

        void DeleteOrderDetail(int id);


    }
}
