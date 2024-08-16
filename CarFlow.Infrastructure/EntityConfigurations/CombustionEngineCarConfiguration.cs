using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class CombustionEngineCarConfiguration : IEntityTypeConfiguration<CombustionEngineCar>
{
    public void Configure(EntityTypeBuilder<CombustionEngineCar> builder)
    {
        builder.ToTable(nameof(CombustionEngineCar));

        builder.Property(cec => cec.Id)
            .ValueGeneratedNever();

        builder.Property(cec => cec.EngineId)
            .IsRequired();

        builder.Property(cec => cec.EuroStandardId)
            .IsRequired();

        builder.Property(cec => cec.CityFuel)
            .HasPrecision(3, 1);

        builder.Property(cec => cec.CombinedFuel)
            .HasPrecision(3, 1);

        builder.Property(cec => cec.HighwayFuel)
            .HasPrecision(3, 1);

        builder.HasOne(cec => cec.IdNavigation)
            .WithOne(c => c.CombustionEngineCar)
            .HasForeignKey<CombustionEngineCar>(cec => cec.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cec => cec.Engine)
            .WithMany(e => e.CombustionEngineCars)
            .HasForeignKey(cec => cec.EngineId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cec => cec.EuroStandard)
            .WithMany(es => es.CombustionEngineCars)
            .HasForeignKey(cec => cec.EuroStandardId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}