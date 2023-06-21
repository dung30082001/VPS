using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly VPSContext _context;

        public int totalBlog;

        public List<Blog> listB;

        public BlogController(VPSContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlog()
        {
            return _context.Blogs.ToList();
        }
        //[HttpGet]
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalBlog()
        {
            listB = _context.Blogs.ToList();

            totalBlog = listB.Count;
            return totalBlog;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlogById(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            return blog;
        }
    }
}
