using Microsoft.EntityFrameworkCore;

namespace CollectiveStartUpClub.Models
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<StartUpClub> StartUpClubs { get; set; }
    }
}
