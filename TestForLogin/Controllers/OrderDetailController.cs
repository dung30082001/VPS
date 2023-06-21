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
        private readonly VPSContext _context;
        public List<OrderDetail> listOD;
        public double finalSum;
        public OrderDetailController(VPSContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetCustomer()
        {
            return _context.OrderDetails.ToList();
        }
        [HttpGet]
        [Route("totalprice")]
        public async Task<double> GetTotalOrder()
        {
            listOD = _context.OrderDetails.ToList();
            foreach (var item in listOD)
            {
                finalSum += item.UnitPrice.Value;
            }
            return finalSum;
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
