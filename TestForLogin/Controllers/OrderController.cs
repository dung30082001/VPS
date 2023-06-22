using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderRepository repository = new OrderRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return repository.GetOrder();
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalOrder()
        {
            return repository.GetTotalOrder();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            return repository.GetOrderById(id);
        }
    }
}
