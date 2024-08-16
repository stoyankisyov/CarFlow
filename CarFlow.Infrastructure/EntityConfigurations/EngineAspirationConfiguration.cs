using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class EngineAspirationConfiguration : IEntityTypeConfiguration<EngineAspiration>
{
    public void Configure(EntityTypeBuilder<EngineAspiration> builder)
    {
        builder.ToTable(nameof(EngineAspiration));

        builder.HasKey(ea => ea.Id);

        builder.Property(ea => ea.Id)
            .ValueGeneratedOnAdd();

        builder.Property(ea => ea.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(ea => ea.Name)
            .IsUnique();

        builder.HasMany(ea => ea.Engines)
            .WithOne(e => e.Aspiration)
            .HasForeignKey(e => e.AspirationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}