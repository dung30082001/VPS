using BusinessObject.Models;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantController : ControllerBase
    {
        private IConsultantRepository repository = new ConsultantRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Consultant>>> GetConsultant()
        {
            return repository.GetConsultant();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Consultant>> GetConsultantById(int id)
        {
            return repository.GetConsultantById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultant(int id, Consultant consultant)
        {
            repository.UpdateConsultant(id, consultant);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteconsultant(int id)
        {
            var account = repository.GetConsultantById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteConsultant(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Consultant>> PostConsultant(Consultant consultant)
        {
            repository.AddConsultant(consultant);
            return NoContent();
        }
    }
}
