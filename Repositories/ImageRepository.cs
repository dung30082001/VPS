using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ImageRepository : IImageRepository
    {
        public void AddImage(Image image)
        {
            ImageDAO.AddImage(image);
        }

        public void DeleteImage(int id)
        {
            ImageDAO.DeleteImage(id);
        }

        public List<Image> GetImage()
        {
            return ImageDAO.GetImage();
        }

        public Image GetImagebyId(int id)
        {
            return ImageDAO.GetImageById(id);
        }

        public void UpdateImage(int id, Image image)
        {
            ImageDAO.UpdateImage(id, image);
        }
    }
}
