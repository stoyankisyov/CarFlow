using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable(nameof(Feature));

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Id)
            .ValueGeneratedOnAdd();

        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(f => f.CarAdvertisementFeatures)
            .WithOne(caf => caf.Feature)
            .HasForeignKey(caf => caf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(f => f.ModelStandardFeatures)
            .WithOne(msf => msf.Feature)
            .HasForeignKey(msf => msf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}