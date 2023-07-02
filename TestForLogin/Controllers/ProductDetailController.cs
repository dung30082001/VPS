using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private IProductDetailRepository repository = new ProductDetailRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<ProductDetail>>> GetProductDetail()
        {
            return repository.GetProductDetail();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetail>> GetProductDetailById(int id)
        {
            return repository.GetProductDetailbyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductDetail(int id, ProductDetail productDetail)
        {
            repository.UpdateProductDetail(id, productDetail);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail(int id)
        {
            var account = repository.GetProductDetailbyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteProductDetail(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<ProductDetail>> PostProductDetail(ProductDetail productDetail)
        {
            repository.AddProductDetail(productDetail);
            return NoContent();
        }
    }
}
