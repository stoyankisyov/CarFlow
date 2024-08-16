using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class ModelStandardFeatureConfiguration : IEntityTypeConfiguration<ModelStandardFeature>
{
    public void Configure(EntityTypeBuilder<ModelStandardFeature> builder)
    {
        builder.ToTable(nameof(ModelStandardFeature));

        builder.HasKey(msf => new { msf.ModelId, msf.FeatureId });

        builder.HasOne(msf => msf.Model)
            .WithMany(m => m.ModelStandardFeatures)
            .HasForeignKey(msf => msf.ModelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(msf => msf.Feature)
            .WithMany(f => f.ModelStandardFeatures)
            .HasForeignKey(msf => msf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}