using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class TunedCarDetailConfiguration : IEntityTypeConfiguration<TunedCarDetail>
{
    public void Configure(EntityTypeBuilder<TunedCarDetail> builder)
    {
        builder.ToTable(nameof(TunedCarDetail));

        builder.HasKey(tcd => tcd.Id);

        builder.Property(tcd => tcd.Id)
            .ValueGeneratedOnAdd();

        builder.Property(tcd => tcd.CarAdvertisementId)
            .IsRequired();

        builder.Property(tcd => tcd.Horsepower);

        builder.HasIndex(tcd => tcd.CarAdvertisementId)
            .IsUnique();

        builder.HasOne(tcd => tcd.CarAdvertisement)
            .WithOne(ca => ca.TunedCarDetail)
            .HasForeignKey<TunedCarDetail>(tcd => tcd.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}