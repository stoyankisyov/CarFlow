using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class SubregionConfiguration : IEntityTypeConfiguration<Subregion>
{
    public void Configure(EntityTypeBuilder<Subregion> builder)
    {
        builder.ToTable(nameof(Subregion));

        builder.HasKey(sr => sr.Id);

        builder.Property(sr => sr.Id)
            .ValueGeneratedOnAdd();

        builder.Property(sr => sr.RegionId)
            .IsRequired();

        builder.Property(sr => sr.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(sr => new { sr.RegionId, sr.Name })
            .IsUnique();

        builder.HasOne(sr => sr.Region)
            .WithMany(r => r.Subregions)
            .HasForeignKey(sr => sr.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(sr => sr.CarAdvertisements)
            .WithOne(ca => ca.Subregion)
            .HasForeignKey(ca => ca.SubregionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}