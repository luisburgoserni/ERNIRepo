using EjemploEFCore.EntityConfig;
using EjemploEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        public DbSet<Cancion> Canciones { get;set;}
        public DbSet<Album> Albunes { get; set; }
        public DbSet<Autor> Autores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CancionEntityConfig.SetCancionEntityConfig(modelBuilder.Entity<Cancion>());

            //modelBuilder.Entity<Cancion>().ToTable("Canciones");
        }
    }
}
