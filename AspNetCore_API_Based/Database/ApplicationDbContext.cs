using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Database
{
    public class ApplicationDbContext : DbContext
    {
        #region Entities

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion Entities

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
