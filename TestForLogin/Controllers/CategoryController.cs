using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository repository = new CategoryRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            return repository.GetCategory();
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalCategory()
        {
            return repository.GetTotalCategory();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            return repository.GetCategoryById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            repository.UpdateCategory(id, category);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var account = repository.GetCategoryById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteCategory(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Category>> PostAccount(Category acc)
        {
            repository.AddCategory(acc);
            return NoContent();
        }
    }
}

