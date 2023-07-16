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
        [Route("listbysaleidd")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderBySaleId(int id)
        {
            return repository.GetOrderBySaleId(id);
        }
        [HttpGet]
        [Route("top4bestbuyer")]
        public IActionResult GetTop4()
        {
            VPSContext context = new VPSContext();
            var list = context.Orders.Include(x => x.Customer)
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, TotalPrice = g.Sum(o => o.Price) })
                .OrderByDescending(x => x.TotalPrice)
                            .Take(4)
                .ToList();
            return Ok(list);
        }
        [HttpGet]
        [Route("listbydate")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderByDate(string from,string to)
        {
            return repository.GetOrderByDate(from,to);
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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            repository.UpdateOrder(id, order);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var account = repository.GetOrderById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteOrder(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order ord)
        {
            repository.AddOrder(ord);
            return NoContent();
        }
    }
}
