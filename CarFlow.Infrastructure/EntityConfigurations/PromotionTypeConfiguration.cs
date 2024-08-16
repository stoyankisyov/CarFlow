using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class PromotionTypeConfiguration : IEntityTypeConfiguration<PromotionType>
{
    public void Configure(EntityTypeBuilder<PromotionType> builder)
    {
        builder.ToTable(nameof(PromotionType));

        builder.HasKey(pt => pt.Id);

        builder.Property(pt => pt.Id)
            .ValueGeneratedOnAdd();

        builder.Property(pt => pt.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(pt => pt.Price)
            .IsRequired()
            .HasPrecision(10, 2);

        builder.HasIndex(pt => new { pt.Name, pt.Price })
            .IsUnique();

        builder.HasMany(pt => pt.Promotions)
            .WithOne(p => p.PromotionType)
            .HasForeignKey(p => p.PromotionTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}