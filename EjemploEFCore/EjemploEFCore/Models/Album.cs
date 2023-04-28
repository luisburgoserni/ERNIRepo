﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Nombre { get; set; }

        public List<Cancion> Canciones { get; set; }

    }
}
