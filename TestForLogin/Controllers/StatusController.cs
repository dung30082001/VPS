using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusRepository repository = new StatusRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Status>>> GetStatus()
        {
            return repository.GetStatus();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Status>> GetStatusById(int id)
        {
            return repository.GetStatusbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatus(int id, Status status)
        {
            repository.UpdateStatus(id, status);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            var account = repository.GetStatusbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteStatus(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Sale>> PostStatus(Status status)
        {
            repository.AddStatus(status);
            return NoContent();
        }
    }
}
