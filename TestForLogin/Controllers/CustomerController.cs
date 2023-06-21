using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly VPSContext _context;

        public List<Customer> listC;

        public int totalC;
        public CustomerController(VPSContext context)
        {
            _context = context;
        }
        private IAccountRepository repository = new AccountRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return _context.Customers.ToList(); 
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalCustomer()
        {
            listC = _context.Customers.ToList();
            totalC = listC.Count;
            return totalC;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            var account = await _context.Customers.FindAsync(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }
    }
}
