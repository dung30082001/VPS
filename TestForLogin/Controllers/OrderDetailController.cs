using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly VPSContext _context;
        public OrderDetailController(VPSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetCustomer()
        {
            return _context.OrderDetails.ToList();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderById(int id)
        {
            var od = await _context.OrderDetails.FindAsync(id);

            if (od == null)
            {
                return NotFound();
            }

            return od;
        }
    }
}
