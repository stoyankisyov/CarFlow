using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class EngineConfigurationConfiguration : IEntityTypeConfiguration<Models.EngineConfiguration>
{
    public void Configure(EntityTypeBuilder<Models.EngineConfiguration> builder)
    {
        builder.ToTable(nameof(Models.EngineConfiguration));

        builder.HasKey(ec => ec.Id);

        builder.Property(ec => ec.Id)
            .ValueGeneratedOnAdd();

        builder.Property(ec => ec.Name)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(ec => ec.CylinderCount)
            .IsRequired();

        builder.HasIndex(ec => new { ec.Name, ec.CylinderCount })
            .IsUnique();

        builder.HasMany(ec => ec.Engines)
            .WithOne(e => e.Configuration)
            .HasForeignKey(e => e.ConfigurationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}