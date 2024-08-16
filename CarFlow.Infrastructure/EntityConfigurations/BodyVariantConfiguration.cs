using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class BodyVariantConfiguration : IEntityTypeConfiguration<BodyVariant>
{
    public void Configure(EntityTypeBuilder<BodyVariant> builder)
    {
        builder.ToTable(nameof(BodyVariant));

        builder.HasKey(bv => bv.Id);

        builder.Property(bv => bv.Id)
            .ValueGeneratedOnAdd();

        builder.Property(bv => bv.BodyId)
            .IsRequired();

        builder.Property(bv => bv.DoorCount)
            .IsRequired();

        builder.Property(bv => bv.SeatCount)
            .IsRequired();

        builder.HasIndex(bv => new { bv.BodyId, bv.DoorCount, bv.SeatCount })
            .IsUnique();

        builder.HasMany(bv => bv.Cars)
            .WithOne(c => c.BodyVariant)
            .HasForeignKey(c => c.BodyVariantId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(bv => bv.Body)
            .WithMany(b => b.BodyVariants)
            .HasForeignKey(bv => bv.BodyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}