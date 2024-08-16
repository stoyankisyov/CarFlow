using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class AccountFavouriteAdvertisementConfiguration : IEntityTypeConfiguration<AccountFavouriteAdvertisement>
{
    public void Configure(EntityTypeBuilder<AccountFavouriteAdvertisement> builder)
    {
        builder.ToTable(nameof(AccountFavouriteAdvertisement));

        builder.HasKey(afa => new { afa.AccountId, afa.AdvertisementId });

        builder.HasOne(afa => afa.Account)
            .WithMany(a => a.AccountFavouriteAdvertisements)
            .HasForeignKey(afa => afa.AccountId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(afa => afa.CarAdvertisement)
            .WithMany(ca => ca.AccountFavouriteAdvertisements)
            .HasForeignKey(afa => afa.AdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}