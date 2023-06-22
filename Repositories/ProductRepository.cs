using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            ProductDAO.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            ProductDAO.DeleteProduct(id);
        }

        public List<Product> GetProduct()
        {
            return ProductDAO.GetProduct();
        }

        public Product GetProductById(int id)
        {
            return ProductDAO.GetProductById(id);
        }

        public int GetTotalProduct()
        {
            return ProductDAO.GetTotalProduct();
        }

        public void UpdateProduct(int id, Product product)
        {
            ProductDAO.UpdateProduct(id,product);
        }
    }
}
