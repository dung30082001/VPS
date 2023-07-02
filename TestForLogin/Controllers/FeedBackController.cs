using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private IFeedBackRepository repository = new FeedBackRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<FeedBack>>> GetFeedBack()
        {
            return repository.GetFeedBack();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<FeedBack>> GetFeedBackById(int id)
        {
            return repository.GetFeedBackbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedBack(int id, FeedBack feedBack)
        {
            repository.UpdateFeedBack(id, feedBack);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedBack(int id)
        {
            var account = repository.GetFeedBackbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteFeedBack(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Conversation>> PostFeedBack(FeedBack feedBack)
        {
            repository.AddFeedBack(feedBack);
            return NoContent();
        }
    }
}
