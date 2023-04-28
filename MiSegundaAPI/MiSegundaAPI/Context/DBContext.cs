using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiSegundaAPI.EntityConfig;
using MiSegundaAPI.Models;

namespace MiSegundaAPI.Context
{
    public class DBContext : DbContext, IDBContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<House> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable(nameof(Person));
            modelBuilder.Entity<House>().ToTable(nameof(House));
            PersonEntityConfig.SetPersonEntityConfig(modelBuilder.Entity<Person>());
            HouseEntityConfig.SetHouseEntityConfig(modelBuilder.Entity<House>());
        }
    }
}
