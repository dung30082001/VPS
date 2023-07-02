using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductDetailRepository
    {
        List<ProductDetail> GetProductDetail();

        ProductDetail GetProductDetailbyId(int id);

        void UpdateProductDetail(int id, ProductDetail productDetail);

        void AddProductDetail(ProductDetail productDetail);

        void DeleteProductDetail(int id);
    }
}
