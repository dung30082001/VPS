using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDetailDAO
    {
        public static List<ProductDetail> GetProductDetail()
        {
            var listProductDetail = new List<ProductDetail>();
            try
            {
                using (var context = new VPSContext())
                {
                    listProductDetail = context.ProductDetails.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProductDetail;
        }
        public static ProductDetail GetProductDetailById(int id)
        {
            var productDetail = new ProductDetail();
            try
            {
                using (var context = new VPSContext())
                {
                    productDetail = context.ProductDetails.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return productDetail;
        }
        public static void UpdateProductDetail(int id, ProductDetail productDetail)
        {
            ProductDetail current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.ProductDetails.Find(id);
                    current.ProductId = productDetail.ProductId;
                    current.ImageId = productDetail.ImageId;
                    context.ProductDetails.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddProductDetail(ProductDetail productDetail)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.ProductDetails.Add(productDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteProductDetail(int id)
        {
            ProductDetail current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.ProductDetails.Find(id);
                    context.ProductDetails.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
