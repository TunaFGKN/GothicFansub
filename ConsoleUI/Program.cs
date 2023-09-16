using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MangaManager mangaManager = new MangaManager(new EfMangaDal());
            MangakaManager mangakaManager = new MangakaManager(new EfMangakaDal());
            GenreManager genreManager = new GenreManager(new EfGenreDal());

            //mangakaManager.Add(new Mangaka { MangakaId = 1, MangakaName = "Eiichiro Oda" });
            //mangakaManager.Add(new Mangaka { MangakaId = 2, MangakaName = "Masashi Kishimoto" });
            //mangakaManager.Add(new Mangaka { MangakaId = 3, MangakaName = "Hirohiko Araki" });
            //mangakaManager.Add(new Mangaka { MangakaId = 4, MangakaName = "Yoshihiro Togashi" });
            //mangakaManager.Add(new Mangaka { MangakaId = 5, MangakaName = "Kentaro Miura" });
            mangakaManager.Add(new Mangaka { MangakaId = 6, MangakaName = "Makoto Yukimura" }); // Vinland Saga
            mangakaManager.Add(new Mangaka { MangakaId = 7, MangakaName = "Akira Toriyama" }); // Dragon Ball
            mangakaManager.Add(new Mangaka { MangakaId = 8, MangakaName = "Tuna Figankaplan" }); // Me ;)

            //GenreManagerTest(genreManager);
        }

        //private static void GenreManagerTest(GenreManager genreManager)
        //{
        //    //genreManager.Add(new Genre { GenreId = 1, GenreName = "Shounen", GenreDescription = "Manga targeted at tween and teen boys." });
        //    //genreManager.Add(new Genre { GenreId = 2, GenreName = "Shojo", GenreDescription = "Manga targeted at tween and teen girls." });
        //    //genreManager.Add(new Genre { GenreId = 3, GenreName = "Seinen", GenreDescription = "Manga targeted at adult men (18+)." }); 
        //    //genreManager.Add(new Genre { GenreId = 4, GenreName = "Josei", GenreDescription = "Manga targeted at adult women(18 +)." });
        //    //genreManager.Add(new Genre { GenreId = 5, GenreName = "Manhwa", GenreDescription = "Webtoons from south korea." });
        //    //genreManager.Add(new Genre { GenreId = 6, GenreName = "Manhua", GenreDescription = "Webtoons from china" });
        //    foreach (var genre in genreManager.GetAll())
        //    {
        //        Console.WriteLine(genre.GenreName + ": " + genre.GenreDescription);
        //    }
        //    Console.WriteLine(genreManager.GetById(1).GenreName);

        //    //genreManager.Add(new Genre { GenreId = 7, GenreName = "temp", GenreDescription = "temp" });
        //    //Console.WriteLine(genreManager.GetById(7).GenreName);
        //    //genreManager.Update(new Genre { GenreId = 7, GenreName = "updatedd", GenreDescription="desc updated" });
        //    //Console.WriteLine(genreManager.GetById(7).GenreName + " " + genreManager.GetById(7).GenreDescription);
        //    //genreManager.Delete(new Genre { GenreId=7 });
        //}
    }
}