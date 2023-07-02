using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        public void AddProductDetail(ProductDetail productDetail)
        {
            ProductDetailDAO.AddProductDetail(productDetail);
        }

        public void DeleteProductDetail(int id)
        {
            ProductDetailDAO.DeleteProductDetail(id);
        }

        public List<ProductDetail> GetProductDetail()
        {
            return ProductDetailDAO.GetProductDetail();
        }

        public ProductDetail GetProductDetailbyId(int id)
        {
            return ProductDetailDAO.GetProductDetailById(id);
        }

        public void UpdateProductDetail(int id, ProductDetail productDetail)
        {
            ProductDetailDAO.UpdateProductDetail(id, productDetail);
        }
    }
}
