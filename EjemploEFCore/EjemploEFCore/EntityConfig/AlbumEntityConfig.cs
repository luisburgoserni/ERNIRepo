using EjemploEFCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.EntityConfig
{
    public class AlbumEntityConfig
    {

        public static void SetAlbumEntityConfig(EntityTypeBuilder<Album> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AlbumId);
            entityBuilder.Property(x => x.Nombre).IsRequired();

            
        }


    }
}
