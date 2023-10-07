using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMangaImageService
    {
        IResult Add(IFormFile file, MangaImage mangaImage);
        IResult Update(IFormFile file, MangaImage mangaImage);
        IResult Delete(MangaImage mangaImage);
        IDataResult<List<MangaImage>> GetAll();
        IDataResult<List<MangaImage>> GetAllByMangaId(int mangaId);
        IDataResult<MangaImage> GetByImageId(int imageId);
    }
}
