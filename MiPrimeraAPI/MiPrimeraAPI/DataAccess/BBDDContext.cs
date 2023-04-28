using Microsoft.EntityFrameworkCore;
using MiPrimeraAPI.Models;

namespace MiPrimeraAPI.DataAccess
{
    public class BBDDContext : DbContext, IBBDDContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options)
        {
            
        }

        public DbSet<ModelItem> ModelItem { get; set; }
    }
}
