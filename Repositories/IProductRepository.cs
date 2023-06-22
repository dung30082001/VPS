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

        Product GetProductById(int id);

        int GetTotalProduct();

        void UpdateProduct(int id, Product product);

        void AddProduct(Product product);

        void DeleteProduct(int id);
    }
}
