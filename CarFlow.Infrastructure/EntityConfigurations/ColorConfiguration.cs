using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable(nameof(Color));

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.HasMany(c => c.CarAdvertisementExteriorColors)
            .WithOne(ca => ca.ExteriorColor)
            .HasForeignKey(ca => ca.ExteriorColorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(c => c.CarAdvertisementInteriorColors)
            .WithOne(ca => ca.InteriorColor)
            .HasForeignKey(ca => ca.InteriorColorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}