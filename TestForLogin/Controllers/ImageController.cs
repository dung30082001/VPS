using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IImageRepository repository = new ImageRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Image>>> GetImage()
        {
            return repository.GetImage();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImageById(int id)
        {
            return repository.GetImagebyId(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImage(int id, Image image)
        {
            repository.UpdateImage(id, image);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var account = repository.GetImagebyId(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteImage(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Conversation>> PostImage(Image image)
        {
            repository.AddImage(image);
            return NoContent();
        }
    }
}
