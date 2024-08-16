using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable(nameof(Model));

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Id)
            .ValueGeneratedOnAdd();

        builder.Property(m => m.BrandId)
            .IsRequired();

        builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.ModelVariant)
            .HasMaxLength(100);

        builder.HasIndex(m => new { m.BrandId, m.Name, m.ModelVariant })
            .IsUnique();

        builder.HasOne(m => m.Brand)
            .WithMany(b => b.Models)
            .HasForeignKey(m => m.BrandId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(m => m.Cars)
            .WithOne(c => c.Model)
            .HasForeignKey(c => c.ModelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(m => m.ModelStandardFeatures)
            .WithOne(msf => msf.Model)
            .HasForeignKey(msf => msf.ModelId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}