using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMangaService
    {
        DataResult<List<Manga>> GetAll();
        DataResult<List<MangaDetailsDto>> GetMangaDetails();
        DataResult<List<Manga>> GetAllByGenreId(int genreId);
        DataResult<List<Manga>> GetAllByMangakaId(int mangakaId);
        DataResult<Manga> GetById(int mangaId);
        Result Add(Manga manga);
        Result Update(Manga manga);
        Result Delete(Manga manga);
    }
}
