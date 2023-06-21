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
        private readonly VPSContext _context;

        public int totalOrder;

        public List<Order> listO;

        public OrderController(VPSContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return _context.Orders.ToList();
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalOrder()
        {
            listO = _context.Orders.ToList();

            totalOrder = listO.Count;
            return totalOrder;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
    }
}
