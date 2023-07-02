using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private ISaleRepository repository = new SaleRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSale()
        {
            return repository.GetSale();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSaleById(int id)
        {
            return repository.GetSalebyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(int id, Sale sale)
        {
            repository.UpdateSale(id, sale);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            var account = repository.GetSalebyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteSale(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Sale>> PostSale(Sale sale)
        {
            repository.AddSale(sale);
            return NoContent();
        }
    }
}
