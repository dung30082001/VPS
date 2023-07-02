using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private IMessageRepository repository = new MessageRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessage()
        {
            return repository.GetMessage();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessageById(int id)
        {
            return repository.GetMessagebyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage(int id, Message message)
        {
            repository.UpdateMessage(id, message);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var account = repository.GetMessagebyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteMessage(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            repository.AddMessage(message);
            return NoContent();
        }
    }
}
