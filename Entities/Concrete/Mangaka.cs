﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mangaka: IEntity
    {
        public int MangakaId { get; set; }
        public string MangakaName { get; set; }
    }
}