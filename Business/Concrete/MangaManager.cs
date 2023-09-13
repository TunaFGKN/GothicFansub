using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MangaManager: IMangaService
    {
        IMangaDal _mangaDal;

        public MangaManager(IMangaDal mangaDal)
        {
            _mangaDal = mangaDal;
        }

        public void Add(Manga manga)
        {
            // Business Codes....
            _mangaDal.Add(manga);
        }

        public void Delete(Manga manga)
        {
            // Business Codes....
            _mangaDal.Delete(manga);
        }

        public List<Manga> GetAll()
        {
            // Business Codes....
            return _mangaDal.GetAll();
        }

        public List<Manga> GetAllByMangakaId(int mangakaId)
        {
            // Business Codes....
            return _mangaDal.GetAll(m => m.MangakaId == mangakaId);
        }

        public List<Manga> GetAllByGenreId(int genreId)
        {
            // Business Codes....
            return _mangaDal.GetAll(m=> m.GenreId == genreId);
        }

        public Manga GetById(int mangaId)
        {
            // Business Codes....
            return _mangaDal.Get(m=>m.MangaId == mangaId);
        }

        public void Update(Manga manga)
        {
            // Business Codes....
            _mangaDal.Update(manga);
        }
    }
}
