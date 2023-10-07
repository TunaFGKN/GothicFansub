using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangaImagesController : ControllerBase
    {
        IMangaImageService _mangaImageService;

        public MangaImagesController(IMangaImageService mangaImageService)
        {
            _mangaImageService = mangaImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mangaImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbymangaid")]
        public IActionResult GetByCarId(int mangaId)
        {
            var result = _mangaImageService.GetAllByMangaId(mangaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _mangaImageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] MangaImage mangaImage)
        {
            var result = _mangaImageService.Add(file, mangaImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] MangaImage mangaImage)
        {
            var result = _mangaImageService.Update(file, mangaImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MangaImage mangaImage)
        {
            var carDeleteImage = _mangaImageService.GetByImageId(mangaImage.ImageId).Data;
            var result = _mangaImageService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
