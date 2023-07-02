using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStockRepository repository = new StockRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStock()
        {
            return repository.GetStock();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById(int id)
        {
            return repository.GetStockbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(int id, Stock stock)
        {
            repository.UpdateStock(id, stock);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var account = repository.GetStockbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteStock(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            repository.AddStock(stock);
            return NoContent();
        }
    }
}
