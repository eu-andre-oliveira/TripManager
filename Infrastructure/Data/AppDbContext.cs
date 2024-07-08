using Core.v1.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TripConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
