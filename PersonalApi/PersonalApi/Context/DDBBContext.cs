using Microsoft.EntityFrameworkCore;

namespace PersonalApi.Context
{
    public class DDBBContext : DbContext, IDDBBContext
    {
        public DDBBContext(DbContextOptions<DDBBContext> options) : base(options)
        {
            
        }
    }
}
