using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProduct();

        List<Product> Get4NewProduct();

        List<Product> Get4ExpensiveProduct();

        List<Product> GetProductByCateId(int cateId);

        List<Product> GetProductByName(string text);

        Product GetProductById(int id);

        int GetTotalProduct();

        void UpdateProduct(int id, Product product);

        void AddProduct(Product product);

        void DeleteProduct(int id);
    }
}
