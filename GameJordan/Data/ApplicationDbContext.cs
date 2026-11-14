using GameJordan.Models;
using Microsoft.EntityFrameworkCore;

namespace GameJordan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action" , DisplayOrder = 1},
                new Category { Id = 2, Name = "Adventure" , DisplayOrder = 2},
                new Category { Id = 3, Name = "RPG" , DisplayOrder = 3},
                new Category { Id = 4, Name = "Strategy" , DisplayOrder = 4},
                new Category { Id = 5, Name = "Sports" , DisplayOrder = 5}
            );
        }
    }
}
