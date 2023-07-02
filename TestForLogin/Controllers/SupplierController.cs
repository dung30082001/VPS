using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierRepository repository = new SupplierRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
        {
            return repository.GetSupplier();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplierById(int id)
        {
            return repository.GetSupplierbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, Supplier supplier)
        {
            repository.UpdateSupplier(id, supplier);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var account = repository.GetSupplierbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteSupplier(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
            repository.AddSupplier(supplier);
            return NoContent();
        }
    }
}
