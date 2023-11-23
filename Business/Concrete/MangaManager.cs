using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
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
        [CacheRemoveAspect("IMangaService.Get")]
        public Result Add(Manga manga)
        {
            _mangaDal.Add(manga);
            return new SuccessResult(Messages.MangaAdded);
        }

        public Result Delete(Manga manga)
        {
            _mangaDal.Delete(manga);
            return new SuccessResult(Messages.MangaDeleted);
        }

        [CacheAspect]
        public DataResult<List<Manga>> GetAll()
        {
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(), Messages.MangasListed);
        }

        public DataResult<List<Manga>> GetAllByMangakaId(int mangakaId)
        {
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(m => m.MangakaId == mangakaId),"msg");
        }

        public DataResult<List<Manga>> GetAllByGenreId(int genreId)
        {
            return new SuccessDataResult<List<Manga>>(_mangaDal.GetAll(m=> m.GenreId == genreId),"msg");
        }

        [CacheAspect]
        public DataResult<Manga> GetById(int mangaId)
        {
            return new SuccessDataResult<Manga>(_mangaDal.Get(m=>m.MangaId == mangaId));
        }

        [CacheRemoveAspect("IMangaService.Get")]
        public Result Update(Manga manga)
        {
            _mangaDal.Update(manga);
            return new SuccessResult(Messages.MangaUpdated);
        }

        public DataResult<List<MangaDetailsDto>> GetMangaDetails()
        {
            return new SuccessDataResult<List<MangaDetailsDto>>(_mangaDal.GetMangaDetails());
        }
    }
}
