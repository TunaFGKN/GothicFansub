using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenreService
    {
        DataResult<List<Genre>> GetAll();
        DataResult<Genre> GetById(int genreId);
        Result Add(Genre genre);
        Result Update(Genre genre);
        Result Delete(Genre genre);
    }
}
