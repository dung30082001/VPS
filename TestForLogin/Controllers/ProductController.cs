using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository repository = new ProductRepository();
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            VPSContext context = new VPSContext();
            return context.Products.Include(x=>x.Category).Include(x=>x.Status).ToList();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return repository.GetProductById(id);
        }
    }
}
