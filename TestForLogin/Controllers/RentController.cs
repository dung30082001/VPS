using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private IRentRepository repository = new RentRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Rent>>> GetRent()
        {
            return repository.GetRent();
        }
        //[HttpGet]
        [HttpGet]
        [Route("cusId")]
        public int GetCustomerbyOrderId(int id)
        {
            return repository.GetCusByOrderId(id);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Rent>> GetRentById(int id)
        {
            return repository.GetRentbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRent(int id, Rent rent)
        {
            repository.UpdateRent(id, rent);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRent(int id)
        {
            var account = repository.GetRentbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteRent(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Rent>> PostRent(Rent rent)
        {
            repository.AddRent(rent);
            return NoContent();
        }
    }
}

