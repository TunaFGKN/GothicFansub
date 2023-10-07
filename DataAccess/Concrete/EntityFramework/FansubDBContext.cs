using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FansubDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FansubDB;Trusted_Connection=true");
        }

        public DbSet<Manga> Mangas{ get; set; }
        public DbSet<Mangaka> Mangakas { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MangaImage> MangaImages { get; set; }
    }
}
