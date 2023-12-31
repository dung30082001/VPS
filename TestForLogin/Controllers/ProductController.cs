﻿using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APIConnect.Controllers
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
            return context.Products.Include(x => x.Category).Include(x => x.Status).ToList();
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
        public IActionResult GetTop4SellingProducts()
        {
            VPSContext context = new VPSContext();
            var topProducts = context.OrderDetails.Include(x => x.Product)
                            .Join(context.Products, od => od.ProductId, p => p.ProductId, (od, p) => new { od, p })
                            .GroupBy(x => new { x.p.ProductId, x.p.ProductName, x.p.Image, x.p.UnitPrice, x.p.UnitInStock, x.p.StatusId, x.p.Brand, x.p.Description, x.p.DiscountDate, x.p.Discount, x.p.Quality, x.p.Maintaince })
                            .Select(g => new
                            {
                                g.Key.ProductId,
                                g.Key.ProductName,
                                g.Key.UnitPrice,
                                g.Key.StatusId,
                                g.Key.Brand,
                                g.Key.Description,
                                g.Key.Discount,
                                g.Key.DiscountDate,
                                g.Key.Quality,
                                Maintainance = g.Key.Maintaince,
                                g.Key.UnitInStock,
                                g.Key.Image,
                                TotalOrder = g.Sum(x => x.od.Quantity)
                            })
                            .OrderByDescending(x => x.TotalOrder)
                            .Take(4)
                            .ToList();
            return Ok(topProducts);
        }

        [HttpGet]
        [Route("top8bestsale")]
        public IActionResult GetTop8SellingProducts()
        {
            VPSContext context = new VPSContext();
            var topProducts = context.OrderDetails.Include(x => x.Product)
                            .Join(context.Products, od => od.ProductId, p => p.ProductId, (od, p) => new { od, p })
                            .GroupBy(x => new { x.p.ProductId, x.p.ProductName, x.p.Image })
                            .Select(g => new
                            {
                                g.Key.ProductId,
                                g.Key.ProductName,
                                g.Key.Image,
                                TotalOrder = g.Sum(x => x.od.Quantity)
                            })
                            .OrderByDescending(x => x.TotalOrder)
                            .Take(8)
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
