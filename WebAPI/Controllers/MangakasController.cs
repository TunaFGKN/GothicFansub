using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangakasController : ControllerBase
    {
        IMangakaService _mangakaService;
        public MangakasController(IMangakaService mangakaService)
        {
            _mangakaService = mangakaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mangakaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _mangakaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Mangaka mangaka)
        {
            var result = _mangakaService.Add(mangaka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Mangaka mangaka)
        {
            var result = (_mangakaService.Delete(mangaka));
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Mangaka mangaka)
        {
            var result = _mangakaService.Update(mangaka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
