using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class SeatMaterialConfiguration : IEntityTypeConfiguration<SeatMaterial>
{
    public void Configure(EntityTypeBuilder<SeatMaterial> builder)
    {
        builder.ToTable(nameof(SeatMaterial));

        builder.HasKey(sm => sm.Id);

        builder.Property(sm => sm.Id)
            .ValueGeneratedOnAdd();

        builder.Property(sm => sm.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(sm => sm.Name)
            .IsUnique();

        builder.HasMany(sm => sm.CarAdvertisements)
            .WithOne(ca => ca.SeatMaterial)
            .HasForeignKey(ca => ca.SeatMaterialId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}