using EjemploEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjemploEF.EntityConfig
{
    public class AutorEntityConfig
    {
        public static void SetAutorEntityConfig(EntityTypeBuilder<Autor> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AutorId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
