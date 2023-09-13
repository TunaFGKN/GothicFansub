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
    public class MangakaManager : IMangakaService
    {
        IMangakaDal _mangakaDal;
        public MangakaManager(IMangakaDal mangakaDal)
        {
            _mangakaDal = mangakaDal;
        }
        public void Add(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Add(mangaka);
        }

        public void Delete(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Delete(mangaka);
        }

        public List<Mangaka> GetAll()
        {
            // Business Codes....
            return _mangakaDal.GetAll();
        }

        public Mangaka GetById(int mangakaId)
        {
            // Business Codes....
            return _mangakaDal.Get(m=>m.MangakaId == mangakaId);
        }

        public void Update(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Update(mangaka);
        }
    }
}
