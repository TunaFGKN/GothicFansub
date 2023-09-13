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
    public class GenreManager : IGenreService
    {
        IGenreDal _genreDal;
        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }
        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public void Delete(Genre genre)
        {
            _genreDal.Delete(genre);
        }

        public List<Genre> GetAll()
        {
            return _genreDal.GetAll();
        }

        public Genre GetById(int genreId)
        {
            return _genreDal.Get(g=>g.GenreId == genreId);
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }
    }
}
