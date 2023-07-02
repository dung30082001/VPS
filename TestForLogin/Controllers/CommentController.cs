using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentRepository repository = new CommentRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComment()
        {
            return repository.GetComment();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetCommentById(int id)
        {
            return repository.GetCommentById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, Comment comment)
        {
            repository.UpdateComment(id, comment);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var account = repository.GetCommentById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteComment(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            repository.AddComment(comment);
            return NoContent();
        }
    }
}
