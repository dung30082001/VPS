using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogRepository repository = new BlogRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlog()
        {
            return repository.GetBlog();
        }
        //[HttpGet]
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalBlog()
        {
            return repository.GetTotalBlog();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlogById(int id)
        {
            return repository.GetBlogById(id);
        }
    }
}
