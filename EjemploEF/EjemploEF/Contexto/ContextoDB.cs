using EjemploEF.EntityConfig;
using EjemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploEF.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options) 
        { 
        
        }

        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Album> Albunes { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CancionEntityConfig.SetCancionEntityConfig(modelBuilder.Entity<Cancion>());
            AutorEntityConfig.SetAutorEntityConfig(modelBuilder.Entity<Autor>());
            AlbumEntityConfig.SetAlbumEntityConfig(modelBuilder.Entity<Album>());


            //modelBuilder.Entity<Cancion>().ToTable("Canciones");
        }
    }
}
