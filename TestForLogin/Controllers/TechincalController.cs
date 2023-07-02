using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechincalController : ControllerBase
    {
        private ItechnicalRepository repository = new TechnicalRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Technical>>> GetTechnical()
        {
            return repository.GetTechical();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Technical>> GetTechnicalById(int id)
        {
            return repository.GetTechincalbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechnical(int id, Technical technical)
        {
            repository.UpdateTechnical(id, technical);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTechnical(int id)
        {
            var account = repository.GetTechincalbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteTechnical(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Technical>> PostTechnical(Technical technical)
        {
            repository.AddTechnical(technical);
            return NoContent();
        }
    }
}
