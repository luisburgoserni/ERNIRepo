using EjemploEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploEFCore.Contexto
{
    public interface IContextoDB
    {

        DbSet<Cancion> Canciones { get; set; }
        DbSet<Album> Albunes { get; set; }
        DbSet<Autor> Autores { get; set; }

        int SaveChanges();      
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
