using Microsoft.EntityFrameworkCore;
using SuperHero_API.Domain;

namespace SuperHero_API.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
