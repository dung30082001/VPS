using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using System.Net;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http;
using RouteAttribute = System.Web.Http.RouteAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    public class ImageUploadController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Upload()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            try
            {
                var provider = new MultipartFormDataStreamProvider(Path.GetTempPath());
                await Request.Content.ReadAsMultipartAsync(provider);

                // Get the uploaded file
                var file = provider.FileData[0];
                var fileName = file.Headers.ContentDisposition.FileName.Trim('\"');

                // Generate a unique file name (or you can use the original file name)
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

                // Set the path where you want to save the file
                var filePath = Path.Combine("C:\\Your\\Storage\\Path", uniqueFileName);

                // Move the file to the storage location
                File.Move(file.LocalFileName, filePath);

                // Return the URL or any other response as needed
                var imageUrl = $"https://yourdomain.com/images/{uniqueFileName}";
                return Request.CreateResponse(HttpStatusCode.OK, imageUrl);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}

