using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private IShipperRepository repository = new ShipperRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Shipper>>> GetShipper()
        {
            return repository.GetShipper();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Shipper>> GetShipperById(int id)
        {
            return repository.GetShipperbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShipper(int id, Shipper shipper)
        {
            repository.UpdateShipper(id, shipper);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipper(int id)
        {
            var account = repository.GetShipperbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteShipper(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Sale>> PostShipper(Shipper shipper)
        {
            repository.AddShipper(shipper);
            return NoContent();
        }
    }
}
