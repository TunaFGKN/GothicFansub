using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMangaService
    {
        List<Manga> GetAll();
        List<Manga> GetAllByGenreId(int genreId);
        List<Manga> GetAllByMangakaId(int mangakaId);
        Manga GetById(int mangaId);
        void Add(Manga manga);
        void Update(Manga manga); 
        void Delete(Manga manga);
    }
}
