using Microsoft.EntityFrameworkCore;

namespace SecretSanta.Models
{
    public class SecretSantaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Present> Presents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=SecretSantaDB.db");
            // AUTOGENERATED ?? base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Present>().ToTable("Presents");
            // AUTOGENERATED ?? base.OnModelCreating(modelBuilder);
        }
    }
}