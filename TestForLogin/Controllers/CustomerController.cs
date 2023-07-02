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
        //[HttpGet]
        //[Route("customerorderid")]
        //public  Customer GetCustomerByOrderId(int id)
        //{
        //    return repository.GetCustomerByOrderId(id);
        //}
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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer cus)
        {
            repository.UpdateCustomer(id, cus);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCus(int id)
        {
            var account = repository.GetCustomerById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteCustomer(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Blog>> PostCustomer(Customer cus)
        {
            repository.AddCustomert(cus);
            return NoContent();
        }
    }
}
