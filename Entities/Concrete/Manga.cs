using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Manga: IEntity
    {
        public int MangaId { get; set; }
        public string MangaName { get; set; }
        public int MangakaId { get; set; }
        public int GenreId { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Rating { get; set; }
    }
}
