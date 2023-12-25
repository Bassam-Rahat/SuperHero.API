using Microsoft.EntityFrameworkCore;

namespace SuperHero.API.Models
{
    public class SuperHeroContext : DbContext
    {
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options) : base(options)
        {
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Additional configurations can be set here
        }
    }
}
