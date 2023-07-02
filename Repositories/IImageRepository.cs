using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IImageRepository
    {
        List<Image> GetImage();

        Image GetImagebyId(int id);

        void UpdateImage(int id, Image image);

        void AddImage(Image image);

        void DeleteImage(int id);
    }
}
