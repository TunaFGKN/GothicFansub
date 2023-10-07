﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MangaImage: IEntity
    {
        //MangakaImages in to-do list!
        [Key]
        public int ImageId { get; set; }
        public int MangaId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
