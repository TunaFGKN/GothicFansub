using Business.Abstract;
using Core.Utilities.Results.Concrete;
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
        public Result Add(Genre genre)
        {
            _genreDal.Add(genre);
            return new SuccessResult();
        }

        public Result Delete(Genre genre)
        {
            _genreDal.Delete(genre);
            return new SuccessResult();
        }

        public DataResult<List<Genre>> GetAll()
        {
            return new SuccessDataResult<List<Genre>>(_genreDal.GetAll());
        }

        public DataResult<Genre> GetById(int genreId)
        {
            return new SuccessDataResult<Genre>(_genreDal.Get(g=>g.GenreId == genreId));
        }

        public Result Update(Genre genre)
        {
            _genreDal.Update(genre);
            return new SuccessResult();
        }
    }
}
