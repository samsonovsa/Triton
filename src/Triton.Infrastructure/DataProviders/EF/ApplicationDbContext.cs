using Microsoft.EntityFrameworkCore;
using Triton.Domain;

namespace Triton.Infrastructure.DataProviders.EF
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(u => u.Address);

            modelBuilder.Entity<Customer>().Property(c => c.FirstName).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.LastName).HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(c => c.City).HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(c => c.Country).HasMaxLength(100);
        }
    }
}
