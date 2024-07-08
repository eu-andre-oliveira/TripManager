using Core.v1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.RegisterName)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasOne(t => t.Trip)
                .WithMany(r => r.Registrations)
                .HasForeignKey(t => t.TripId);
        }
    }
}
