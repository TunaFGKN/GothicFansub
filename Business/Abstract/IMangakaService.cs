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
        List<Mangaka> GetAll();
        Mangaka GetById(int mangakaId);
        void Add(Mangaka mangaka);
        void Update(Mangaka mangaka);
        void Delete(Mangaka mangaka);
    }
}
