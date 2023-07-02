using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierStockController : ControllerBase
    {
        private ISupplierStockRepository repository = new SupplierStockRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<SupplierStock>>> GetSupplierStock()
        {
            return repository.GetSupplierStock();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierStock>> GetSupplierStockById(int id)
        {
            return repository.GetSupplierStockbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, SupplierStock supplierStock)
        {
            repository.UpdateSupplierStaock(id, supplierStock);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierStock(int id)
        {
            var account = repository.GetSupplierStockbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteSupplierStock(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<SupplierStock>> PostSupplierStock(SupplierStock supplierStock)
        {
            repository.AddSupplierStock(supplierStock);
            return NoContent();
        }
    }
}
