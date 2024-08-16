using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class FuelTypeConfiguration : IEntityTypeConfiguration<FuelType>
{
    public void Configure(EntityTypeBuilder<FuelType> builder)
    {
        builder.ToTable(nameof(FuelType));

        builder.HasKey(ft => ft.Id);

        builder.Property(ft => ft.Id)
            .ValueGeneratedOnAdd();

        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(ft => ft.Name)
            .IsUnique();

        builder.HasMany(ft => ft.Engines)
            .WithOne(e => e.FuelType)
            .HasForeignKey(e => e.FuelTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}