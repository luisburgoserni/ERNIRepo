using EjemploEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjemploEF.EntityConfig
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
