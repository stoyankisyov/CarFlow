using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable(nameof(Account));

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedOnAdd();

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(a => a.Email)
            .IsRequired()
            .HasMaxLength(320);

        builder.Property(a => a.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(a => a.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.StreetAddress)
            .HasMaxLength(100);

        builder.HasIndex(a => a.Email)
            .IsUnique();

        builder.HasIndex(a => a.Phone)
            .IsUnique();

        builder.HasMany(a => a.CarAdvertisements)
            .WithOne(a => a.Account)
            .HasForeignKey(a => a.AccountId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.AccountRoles)
            .WithOne(ar => ar.Account)
            .HasForeignKey(ar => ar.AccountId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.AccountFavouriteAdvertisements)
            .WithOne(afa => afa.Account)
            .HasForeignKey(afa => afa.AccountId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}