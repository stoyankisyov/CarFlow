using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class TransmissionVariantConfiguration : IEntityTypeConfiguration<TransmissionVariant>
{
    public void Configure(EntityTypeBuilder<TransmissionVariant> builder)
    {
        builder.ToTable(nameof(TransmissionVariant));

        builder.HasKey(tv => tv.Id);

        builder.Property(tv => tv.Id)
            .ValueGeneratedOnAdd();

        builder.Property(tv => tv.TransmissionId)
            .IsRequired();

        builder.Property(tv => tv.GearCount)
            .IsRequired();

        builder.HasIndex(tv => new { tv.TransmissionId, tv.GearCount })
            .IsUnique();

        builder.HasOne(tv => tv.Transmission)
            .WithMany(t => t.TransmissionVariants)
            .HasForeignKey(tv => tv.TransmissionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(tv => tv.Cars)
            .WithOne(c => c.TransmissionVariant)
            .HasForeignKey(c => c.TransmissionVariantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}