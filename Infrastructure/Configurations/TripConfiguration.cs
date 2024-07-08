using Core.v1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.TripName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.TripDescription).HasMaxLength(100);

            builder.HasMany(t => t.Registrations)
                .WithOne(r => r.Trip)
                .HasForeignKey(r => r.TripId);
        }
    }
}
