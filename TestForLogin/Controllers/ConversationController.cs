using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationController : ControllerBase
    {
        private IConversatitonRepository repository = new ConversationRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Conversation>>> GetConversation()
        {
            return repository.GetConversation();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Conversation>> GetConversationById(int id)
        {
            return repository.GetConversationById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConversation(int id, Conversation conversation)
        {
            repository.UpdateConversation(id, conversation);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConversation(int id)
        {
            var account = repository.GetConversationById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteConversation(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Conversation>> PostConversation(Conversation conversation)
        {
            repository.AddConversation(conversation);
            return NoContent();
        }
    }
}
