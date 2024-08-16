using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class EngineConfiguration : IEntityTypeConfiguration<Engine>
{
    public void Configure(EntityTypeBuilder<Engine> builder)
    {
        builder.ToTable(nameof(Engine));

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.Model)
            .HasMaxLength(50);

        builder.Property(e => e.Displacement)
            .IsRequired();

        builder.Property(e => e.Horsepower)
            .IsRequired();

        builder.Property(e => e.Torque)
            .IsRequired();

        builder.Property(e => e.FuelTypeId)
            .IsRequired();

        builder.Property(e => e.ConfigurationId)
            .IsRequired();

        builder.Property(e => e.AspirationId)
            .IsRequired();

        builder.HasOne(e => e.FuelType)
            .WithMany(ft => ft.Engines)
            .HasForeignKey(e => e.FuelTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Configuration)
            .WithMany(ec => ec.Engines)
            .HasForeignKey(e => e.ConfigurationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Aspiration)
            .WithMany(ea => ea.Engines)
            .HasForeignKey(e => e.AspirationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.CombustionEngineCars)
            .WithOne(cec => cec.Engine)
            .HasForeignKey(cec => cec.EngineId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}