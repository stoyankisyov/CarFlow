using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class CarAdvertisementConfiguration : IEntityTypeConfiguration<CarAdvertisement>
{
    public void Configure(EntityTypeBuilder<CarAdvertisement> builder)
    {
        builder.ToTable(nameof(CarAdvertisement));

        builder.HasKey(ca => ca.Id);

        builder.Property(ca => ca.Id)
            .ValueGeneratedOnAdd();

        builder.Property(ca => ca.AccountId)
            .IsRequired();

        builder.Property(ca => ca.ConditionId)
            .IsRequired();

        builder.Property(ca => ca.CarId)
            .IsRequired();

        builder.Property(ca => ca.ExteriorColorId)
            .IsRequired();

        builder.Property(ca => ca.InteriorColorId)
            .IsRequired();

        builder.Property(ca => ca.SeatMaterialId)
            .IsRequired();

        builder.Property(ca => ca.SubregionId)
            .IsRequired();

        builder.Property(ca => ca.CreationDate)
            .IsRequired();

        builder.Property(ca => ca.ExpirationDate)
            .IsRequired();

        builder.Property(ca => ca.ViewCount)
            .IsRequired();

        builder.Property(ca => ca.Title)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(ca => ca.Description)
            .HasMaxLength(3000);

        builder.Property(ca => ca.Mileage)
            .IsRequired();

        builder.Property(ca => ca.Price)
            .IsRequired();

        builder.Property(ca => ca.ManufactureYear)
            .IsRequired();

        builder.Property(ca => ca.RegistrationYear);

        builder.Property(ca => ca.Warranty);

        builder.Property(ca => ca.Vin)
            .HasMaxLength(17);

        builder.Property(ca => ca.OwnerCount);

        builder.Property(ca => ca.VideoUrl)
            .HasMaxLength(2050);

        builder.HasIndex(ca => ca.Vin)
            .IsUnique();

        builder.HasOne(ca => ca.Account)
            .WithMany(a => a.CarAdvertisements)
            .HasForeignKey(ca => ca.AccountId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.Condition)
            .WithMany(c => c.CarAdvertisements)
            .HasForeignKey(ca => ca.ConditionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.Car)
            .WithMany(c => c.CarAdvertisements)
            .HasForeignKey(ca => ca.CarId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.ExteriorColor)
            .WithMany(c => c.CarAdvertisementExteriorColors)
            .HasForeignKey(ca => ca.ExteriorColorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.InteriorColor)
            .WithMany(c => c.CarAdvertisementInteriorColors)
            .HasForeignKey(ca => ca.InteriorColorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.SeatMaterial)
            .WithMany(sm => sm.CarAdvertisements)
            .HasForeignKey(ca => ca.SeatMaterialId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.Subregion)
            .WithMany(sr => sr.CarAdvertisements)
            .HasForeignKey(ca => ca.SubregionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(ca => ca.Promotions)
            .WithOne(p => p.CarAdvertisement)
            .HasForeignKey(p => p.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(ca => ca.AccountFavouriteAdvertisements)
            .WithOne(afa => afa.CarAdvertisement)
            .HasForeignKey(afa => afa.AdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(ca => ca.CarAdvertisementImages)
            .WithOne(cai => cai.CarAdvertisement)
            .HasForeignKey(cai => cai.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(ca => ca.CarAdvertisementFeature)
            .WithOne(caf => caf.CarAdvertisement)
            .HasForeignKey(caf => caf.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ca => ca.TunedCarDetail)
            .WithOne(tcd => tcd.CarAdvertisement)
            .HasForeignKey<TunedCarDetail>(tcd => tcd.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}