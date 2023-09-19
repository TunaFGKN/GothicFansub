using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMangakaService
    {
        DataResult<List<Mangaka>> GetAll();
        DataResult<Mangaka> GetById(int mangakaId);
        Result Add(Mangaka mangaka);
        Result Update(Mangaka mangaka);
        Result Delete(Mangaka mangaka);
    }
}
