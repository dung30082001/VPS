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
        [HttpGet("[action]/{cateid}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductByCateId(int cateid)
        {
            return repository.GetProductByCateId(cateid);
        }
        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return repository.GetProductById(id);
        }
        [HttpGet("[action]/{text}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductByText(string text)
        {
            return repository.GetProductByName(text);
        }
        [HttpGet]
        [Route("top4newproduct")]
        public async Task<ActionResult<IEnumerable<Product>>> GetTop4NewProduct()
        {
            return repository.Get4NewProduct();
        }
        [HttpGet]
        [Route("top4expensiveproduct")]
        public async Task<ActionResult<IEnumerable<Product>>> GetTop4ExpensiveProduct()
        {
            return repository.Get4ExpensiveProduct();
        }
        [HttpGet]
        [Route("top4bestsale")]
        public IActionResult GetTopSellingProducts()
        {
            VPSContext context = new VPSContext();
            var topProducts = context.OrderDetails.Include(x => x.Product)
                            .Join(context.Products, od => od.ProductId, p => p.ProductId, (od, p) => new { od, p })
                            .GroupBy(x => new { x.p.ProductId, x.p.ProductName, x.p.Image })
                            .Select(g => new
                            {
                                ProductId = g.Key.ProductId,
                                ProductName = g.Key.ProductName,
                                Image = g.Key.Image,
                                TotalOrder = g.Sum(x => x.od.Quantity)
                            })
                            .OrderByDescending(x => x.TotalOrder)
                            .Take(5)
                            .ToList();
             return Ok(topProducts);
        }
  
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            repository.UpdateProduct(id, product);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            var account = repository.GetProductById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteProduct(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProductt(Product product)
        {
            repository.AddProduct(product);
            return NoContent();
        }
    }
}
