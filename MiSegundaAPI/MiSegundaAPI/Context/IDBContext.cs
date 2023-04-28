using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MiSegundaAPI.Models;
using System.Runtime.CompilerServices;

namespace MiSegundaAPI.Context
{
    public interface IDBContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<House> Houses { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
