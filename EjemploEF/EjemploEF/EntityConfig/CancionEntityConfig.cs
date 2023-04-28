using EjemploEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjemploEF.EntityConfig
{
    public class CancionEntityConfig
    {
        public static void SetCancionEntityConfig(EntityTypeBuilder<Cancion> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CancionId);
            entityBuilder.Property(x => x.Titulo).IsRequired();
            entityBuilder.Property(x => x.Descripcion).HasMaxLength(100);
        }
    }
}
