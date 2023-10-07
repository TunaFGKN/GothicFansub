using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MangaImageManager : IMangaImageService
    {
        IMangaImageDal _mangaImageDal;
        IFileHelper _fileHelper;

        public MangaImageManager(IMangaImageDal mangaImageDal, IFileHelper fileHelper)
        {
            _mangaImageDal = mangaImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, MangaImage mangaImage)
        {
            IResult result = BusinessRules.Run(CheckMangaImageLimit(mangaImage.MangaId));
            if (result != null)
            {
                return result;
            }
            mangaImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            mangaImage.Date = DateTime.Now;
            _mangaImageDal.Add(mangaImage);
            return new SuccessResult(Messages.MangaImageAdded);
        }

        public IResult Delete(MangaImage mangaImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + mangaImage.ImagePath);
            _mangaImageDal.Delete(mangaImage);
            return new SuccessResult(Messages.MangaImageDeleted);
        }

        public IDataResult<List<MangaImage>> GetAll()
        {
            return new SuccessDataResult<List<MangaImage>>(_mangaImageDal.GetAll(), Messages.MangaImagesListed);
        }

        public IDataResult<List<MangaImage>> GetAllByMangaId(int mangaId)
        {
            return new SuccessDataResult<List<MangaImage>>(_mangaImageDal.GetAll(i => i.MangaId == mangaId), Messages.MangaImagesListedByMangaId);
        }

        public IDataResult<MangaImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<MangaImage>(_mangaImageDal.Get(i => i.ImageId == imageId));
        }

        public IResult Update(IFormFile file, MangaImage mangaImage)
        {
            mangaImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + mangaImage.ImagePath, PathConstants.ImagesPath);
            _mangaImageDal.Update(mangaImage);
            return new SuccessResult(Messages.MangaImageUpdated);
        }

        private IResult CheckMangaImageLimit(int mangaId)
        {
            var result = _mangaImageDal.GetAll(i => i.MangaId == mangaId).Count();
            if (result >= 5)
            {
                return new ErrorResult(Messages.MangaImageCountLimit);
            }
            return new SuccessResult();
        }
    }
}
