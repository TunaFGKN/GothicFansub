using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MangaDetailsDto: IDto
    {
        public int MangaId { get; set; }
        public string MangaName { get; set; }
        public string MangakaName { get; set; }
        public string GenreName { get; set; }
        public int ReleaseYear { get; set; }
    }
}
