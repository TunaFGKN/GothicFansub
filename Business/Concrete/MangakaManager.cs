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
    public class MangakaManager : IMangakaService
    {
        IMangakaDal _mangakaDal;
        public MangakaManager(IMangakaDal mangakaDal)
        {
            _mangakaDal = mangakaDal;
        }
        public Result Add(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Add(mangaka);
            return new SuccessResult();
        }

        public Result Delete(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Delete(mangaka);
            return new SuccessResult();
        }

        public DataResult<List<Mangaka>> GetAll()
        {
            // Business Codes....
            return new SuccessDataResult<List<Mangaka>>(_mangakaDal.GetAll());
        }

        public DataResult<Mangaka> GetById(int mangakaId)
        {
            // Business Codes....
            return new SuccessDataResult<Mangaka>(_mangakaDal.Get(m=>m.MangakaId == mangakaId));
        }

        public Result Update(Mangaka mangaka)
        {
            // Business Codes....
            _mangakaDal.Update(mangaka);
            return new SuccessResult();
        }
    }
}
