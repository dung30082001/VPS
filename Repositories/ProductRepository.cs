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

        public List<Product> Get4ExpensiveProduct()
        {
            return ProductDAO.Get4ExpensiveProduct();
        }

        public List<Product> Get4NewProduct()
        {
            return ProductDAO.Get4NewProduct();
        }

        public List<Product> GetProduct()
        {
            return ProductDAO.GetProduct();
        }

        public List<Product> GetProductByCateId(int cateId)
        {
            return ProductDAO.GetProductByCateId(cateId);
        }

        public Product GetProductById(int id)
        {
            return ProductDAO.GetProductById(id);
        }

        public List<Product> GetProductByName(string text)
        {
            return ProductDAO.GetProductByString(text);
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
