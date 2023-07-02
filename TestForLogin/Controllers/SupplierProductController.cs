using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierProductController : ControllerBase
    {
        private ISupplierProductRepository repository = new SupplierProductRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<SupplierProduct>>> GetSupplierProduct()
        {
            return repository.GetSupplierProduct();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierProduct>> GetSupplierProductById(int id)
        {
            return repository.GetSupplierProductbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, SupplierProduct supplierProduct)
        {
            repository.UpdateSupplierProduct(id, supplierProduct);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierProduct(int id)
        {
            var account = repository.GetSupplierProductbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteSupplierProduct(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<SupplierProduct>> PostSupplierProduct(SupplierProduct supplierProduct)
        {
            repository.AddSupplierProduct(supplierProduct);
            return NoContent();
        }
    }
}
