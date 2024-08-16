using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class CarAdvertisementImageConfiguration : IEntityTypeConfiguration<CarAdvertisementImage>
{
    public void Configure(EntityTypeBuilder<CarAdvertisementImage> builder)
    {
        builder.ToTable(nameof(CarAdvertisementImage));

        builder.HasKey(cai => cai.Id);

        builder.Property(cai => cai.Id)
            .ValueGeneratedOnAdd();

        builder.Property(cai => cai.CarAdvertisementId)
            .IsRequired();

        builder.Property(cai => cai.ImageData)
            .IsRequired()
            .HasColumnType("VARBINARY(MAX)");

        builder.HasOne(cai => cai.CarAdvertisement)
            .WithMany(ca => ca.CarAdvertisementImages)
            .HasForeignKey(cai => cai.CarAdvertisementId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}