using Serilog_JWT_Other.Entities;
using Microsoft.EntityFrameworkCore;

namespace Serilog_JWT_Other.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your tables here as DbSet<T>
        public DbSet<AuthorEntity> AuthorDbSet { get; set; }


        // You can override OnModelCreating if you need additional configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration here if needed
        }
    }
}
