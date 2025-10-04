using Microsoft.EntityFrameworkCore;
using TaskMVC1.Models;

namespace TaskMVC1.Data
{
    public class ApplecationDbContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=TaskMVC1Db;Trusted_Connection=True;TrustServerCertificate=True");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Clothing" }

                );

        }
    }
}
