using api.net.core.ejemplo.dataaccess.contracts;
using api.net.core.ejemplo.dataaccess.contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.dataaccess
{
    public class BBDDContext : DbContext , IBBDDContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options)
        {

        }

        public DbSet<ModelItem> ModelItem { get; set; }

        public int SaveChanges(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
