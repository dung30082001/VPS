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
        private ICustomerRepository repository = new CustomerRepository();

        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return repository.GetCustomer(); 
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalCustomer()
        {
            return repository.GetTotalCustomer();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            return repository.GetCustomerById(id);
        }
    }
}
