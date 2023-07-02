using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ImageDAO
    {
        public static List<Image> GetImage()
        {
            var listImage = new List<Image>();
            try
            {
                using (var context = new VPSContext())
                {
                    listImage = context.Images.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listImage;
        }
        public static Image GetImageById(int id)
        {
            var image = new Image();
            try
            {
                using (var context = new VPSContext())
                {
                    image = context.Images.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return image;
        }
        public static void UpdateImage(int id, Image image)
        {
            Image current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Images.Find(id);
                    current.ImageName = image.ImageName;
                    context.Images.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddImage(Image image)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Images.Add(image);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteImage(int id)
        {
            Image current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Images.Find(id);
                    context.Images.Remove(current);
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
