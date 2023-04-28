using EjemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploEF.Contexto
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
