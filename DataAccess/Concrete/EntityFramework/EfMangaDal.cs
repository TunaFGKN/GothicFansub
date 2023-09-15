using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMangaDal : EfEntityRepositoryBase<Manga, FansubDBContext>, IMangaDal
    {
        public List<MangaDetailsDto> GetMangaDetails()
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var result = from m in context.Mangas
                             join mk in context.Mangakas on m.MangakaId equals mk.MangakaId
                             join g in context.Genres on m.GenreId equals g.GenreId
                             select new MangaDetailsDto { MangaId=m.MangaId,MangakaName=mk.MangakaName,GenreName=g.GenreName,MangaName=m.MangaName,ReleaseYear=m.ReleaseYear };

                return result.ToList();
            }
        }
    }
}
