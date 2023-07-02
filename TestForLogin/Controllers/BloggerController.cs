using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        private IBloggerRepository repository = new BloggerRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Blogger>>> GetBlogger()
        {
            return repository.GetBlogger();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Blogger>> GetBloggerById(int id)
        {
            return repository.GetBloggerById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogger(int id, Blogger blogger)
        {
            repository.UpdateBlogger(id, blogger);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogger(int id)
        {
            var account = repository.GetBloggerById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteBlogger(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Blogger>> PostBlogger(Blogger blogger)
        {
            repository.AddBlogger(blogger);
            return NoContent();
        }
    }
}
