using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        public static List<Product> GetProduct()
        {
            List<Product> product;
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products.Include(x=>x.Category).Include(y=>y.Status).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }
        public static List<Product> Get4NewProduct()
        {
            List<Product> product;
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products
                        .OrderByDescending(p => p.ProductId)
                        .Take(4)
                        .ToList(); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }
        public static List<Product> Get4ExpensiveProduct()
        {
            List<Product> product;
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products
                        .OrderByDescending(p => p.UnitPrice)
                        .Take(4)
                        .ToList(); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }
        public static List<Product> GetProductByCateId(int cateId)
        {
            List<Product> product;
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products
                        .Where(x => x.CategoryId == cateId).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        public static List<Product> GetProductByString(string text)
        {
            List<Product> product;
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products
                        .Where(p => p.ProductName.Contains(text))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }
        public static Product GetProductById(int id)
        {
            var product = new Product();
            try
            {
                using (var context = new VPSContext())
                {
                    product = context.Products.Include(x => x.Category).Include(y=>y.Status).First(x=>x.ProductId==id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }
        public static int GetTotalProduct()
        {
            int finalproduct;
            var listP = new List<Product>();
            try
            {
                using (var context = new VPSContext())
                {
                    listP = context.Products.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalproduct = listP.Count;
            return finalproduct;
        }
        public static void UpdateProduct(int id, Product product)
        {
            Product current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Products.Find(id);
                    current.ProductName = product.ProductName;
                    current.CategoryId = product.CategoryId;
                    current.UnitInStock = product.UnitInStock;
                    current.UnitPrice = product.UnitPrice;
                    current.Image = product.Image;
                    current.StatusId = product.StatusId;
                    current.Brand = product.Brand;
                    current.Description = product.Description;
                    current.DiscountDate = product.DiscountDate;
                    current.Quality = product.Quality; 
                    current.Maintaince = product.Maintaince;
                    context.Products.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddProduct(Product product)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteProduct(int id)
        {
            Product current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Products.Find(id);
                    context.Products.Remove(current);
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
