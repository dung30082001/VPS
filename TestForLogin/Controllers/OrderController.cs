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
        [Route("doanhthuthang1")]
        public IActionResult GetOrder1()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-01-01") && o.OrderDate <= Convert.ToDateTime("2023-01-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang2")]
        public IActionResult GetOrder2()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-02-01") && o.OrderDate <= Convert.ToDateTime("2023-02-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang3")]
        public IActionResult GetOrder3()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-03-01") && o.OrderDate <= Convert.ToDateTime("2023-03-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang4")]
        public IActionResult GetOrder4()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-04-01") && o.OrderDate <= Convert.ToDateTime("2023-04-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang5")]
        public IActionResult GetOrder5()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-05-01") && o.OrderDate <= Convert.ToDateTime("2023-05-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang6")]
        public IActionResult GetOrder6()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-06-01") && o.OrderDate <= Convert.ToDateTime("2023-06-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang7")]
        public IActionResult GetOrder7()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-07-01") && o.OrderDate <= Convert.ToDateTime("2023-07-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang8")]
        public IActionResult GetOrder8()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-08-01") && o.OrderDate <= Convert.ToDateTime("2023-08-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang9")]
        public IActionResult GetOrder9()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-09-01") && o.OrderDate <= Convert.ToDateTime("2023-09-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang10")]
        public IActionResult GetOrder10()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-10-01") && o.OrderDate <= Convert.ToDateTime("2023-10-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang11")]
        public IActionResult GetOrder11()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-11-01") && o.OrderDate <= Convert.ToDateTime("2023-11-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
        }
        [HttpGet]
        [Route("doanhthuthang12")]
        public IActionResult GetOrder12()
        {
            VPSContext context = new VPSContext();
            var totalRevenue = context.Orders
        .Where(o => o.OrderDate >= Convert.ToDateTime("2023-12-01") && o.OrderDate <= Convert.ToDateTime("2023-12-30"))
        .Sum(o => o.Price);
            return Ok(totalRevenue);
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
