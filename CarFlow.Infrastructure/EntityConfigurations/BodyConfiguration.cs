using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class BodyConfiguration : IEntityTypeConfiguration<Body>
{
    public void Configure(EntityTypeBuilder<Body> builder)
    {
        builder.ToTable(nameof(Body));

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();

        builder.Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(b => b.Name)
            .IsUnique();

        builder.HasMany(b => b.BodyVariants)
            .WithOne(bv => bv.Body)
            .HasForeignKey(bv => bv.BodyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}