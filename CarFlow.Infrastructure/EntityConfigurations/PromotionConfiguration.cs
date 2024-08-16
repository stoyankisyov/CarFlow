using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
{
    public void Configure(EntityTypeBuilder<Promotion> builder)
    {
        builder.ToTable(nameof(Promotion));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.CarAdvertisementId)
            .IsRequired();

        builder.Property(p => p.PromotionTypeId)
            .IsRequired();

        builder.Property(p => p.ExpirationDate)
            .IsRequired();

        builder.HasOne(p => p.CarAdvertisement)
            .WithMany(ca => ca.Promotions)
            .HasForeignKey(p => p.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.PromotionType)
            .WithMany(pt => pt.Promotions)
            .HasForeignKey(p => p.PromotionTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}