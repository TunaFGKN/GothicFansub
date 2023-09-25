using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangasController : ControllerBase
    {
        IMangaService _mangaService;
        public MangasController(IMangaService mangaService)
        {
            _mangaService = mangaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mangaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _mangaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getmangadetails")]
        public IActionResult GetMangaDetails()
        {
            var result = _mangaService.GetMangaDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbygenreid")]
        public IActionResult GetAllByGenreId(int id)
        {
            var result = _mangaService.GetAllByGenreId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbymangakaid")]
        public IActionResult GetAllByMangakaId(int id)
        {
            var result = _mangaService.GetAllByMangakaId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Manga manga)
        {
            var result = _mangaService.Add(manga);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Manga manga)
        {
            var result = (_mangaService.Delete(manga));
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Manga manga)
        {
            var result = _mangaService.Update(manga);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
