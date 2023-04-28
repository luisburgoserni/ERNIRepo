using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiSegundaAPI.Models;

namespace MiSegundaAPI.EntityConfig
{
    public class HouseEntityConfig
    {
        public static void SetHouseEntityConfig(EntityTypeBuilder<House> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Size).HasColumnType("decimal");
        }
    }
}
