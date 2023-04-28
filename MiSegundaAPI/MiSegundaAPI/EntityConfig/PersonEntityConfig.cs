using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiSegundaAPI.Models;

namespace MiSegundaAPI.EntityConfig
{
    public class PersonEntityConfig
    {
        public static void SetPersonEntityConfig(EntityTypeBuilder<Person> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Subname).IsRequired();
            entityBuilder.Property(x => x.Age).HasMaxLength(3);
        }
    }
}
