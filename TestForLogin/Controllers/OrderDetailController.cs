using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private IOrderDetailRepository repository = new OrderDetailRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetail()
        {
            return repository.GetOrderDetail();
        }
        [HttpGet]
        [Route("listbyod")]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetailByOrderId(int id)
        {
            return repository.GetOrderDetailByOrderId(id);
        }
        [HttpGet]
        [Route("totalprice")]
        public async Task<double> GetTotalOrder()
        {
            return repository.GetTotalOrderDetail();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderById(int id)
        {
            return repository.GetOrderDetailById(id);
        }
    }
}
