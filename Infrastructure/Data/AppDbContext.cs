using Core.v1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
