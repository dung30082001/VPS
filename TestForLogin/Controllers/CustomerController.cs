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
        public CustomerController(VPSContext context)
        {
            _context = context;
        }
        private IAccountRepository repository = new AccountRepository();
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return _context.Customers.ToList(); 
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
