using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [ValidationAspect(typeof(MangaValidator))]
        public Result Add(Manga manga)
        {
            // Business Codes....
            _mangaDal.Add(manga);
            return new SuccessResult("Added");
        }

        public Result Delete(Manga manga)
        {
            // Business Codes....
            _mangaDal.Delete(manga);
            return new SuccessResult("Deleted");
        }

        public DataResult<List<Manga>> GetAll()
        {
            // Business Codes....
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(),"msg");
        }

        public DataResult<List<Manga>> GetAllByMangakaId(int mangakaId)
        {
            // Business Codes....
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(m => m.MangakaId == mangakaId),"msg");
        }

        public DataResult<List<Manga>> GetAllByGenreId(int genreId)
        {
            // Business Codes....
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(m=> m.GenreId == genreId),"msg");
        }

        public DataResult<Manga> GetById(int mangaId)
        {
            // Business Codes....
            return new SuccessDataResult<Manga>(_mangaDal.Get(m=>m.MangaId == mangaId));
        }

        public Result Update(Manga manga)
        {
            // Business Codes....
            _mangaDal.Update(manga);
            return new SuccessResult("Updated");
        }

        public DataResult<List<MangaDetailsDto>> GetMangaDetails()
        {
            return new SuccessDataResult<List<MangaDetailsDto>>(_mangaDal.GetMangaDetails());
        }
    }
}
