using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class CarAdvertisementFeatureConfiguration : IEntityTypeConfiguration<CarAdvertisementFeature>
{
    public void Configure(EntityTypeBuilder<CarAdvertisementFeature> builder)
    {
        builder.ToTable(nameof(CarAdvertisementFeature));

        builder.HasKey(caf => new { caf.CarAdvertisementId, caf.FeatureId });

        builder.HasOne(caf => caf.CarAdvertisement)
            .WithMany(ca => ca.CarAdvertisementFeature)
            .HasForeignKey(caf => caf.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(caf => caf.Feature)
            .WithMany(f => f.CarAdvertisementFeatures)
            .HasForeignKey(caf => caf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}