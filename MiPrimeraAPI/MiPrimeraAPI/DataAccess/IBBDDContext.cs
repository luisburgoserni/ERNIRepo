using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MiPrimeraAPI.Models;

namespace MiPrimeraAPI.DataAccess
{
    public interface IBBDDContext
    {
        DbSet<ModelItem> ModelItem { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        int SaveChanges(CancellationToken cancellationToken = default(CancellationToken));

        void RemoveRange(IEnumerable<object> entities);

        EntityEntry Update(object entity);
    }
}
