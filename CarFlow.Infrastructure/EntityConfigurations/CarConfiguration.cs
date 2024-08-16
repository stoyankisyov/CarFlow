using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable(nameof(Car));

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ModelId)
            .IsRequired();

        builder.Property(c => c.Generation)
            .HasMaxLength(50);

        builder.Property(c => c.BodyVariantId)
            .IsRequired();

        builder.Property(c => c.TransmissionVariantId)
            .IsRequired();

        builder.Property(c => c.DrivetrainId)
            .IsRequired();

        builder.Property(c => c.StartYear)
            .IsRequired();

        builder.Property(c => c.EndYear);

        builder.HasIndex(c => new
        {
            c.ModelId, c.Generation, c.BodyVariantId, c.TransmissionVariantId, c.DrivetrainId, c.StartYear,
            c.EndYear
        }).IsUnique();

        builder.HasOne(c => c.Model)
            .WithMany(m => m.Cars)
            .HasForeignKey(c => c.ModelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.BodyVariant)
            .WithMany(bv => bv.Cars)
            .HasForeignKey(c => c.BodyVariantId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.TransmissionVariant)
            .WithMany(tv => tv.Cars)
            .HasForeignKey(c => c.TransmissionVariantId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Drivetrain)
            .WithMany(d => d.Cars)
            .HasForeignKey(c => c.DrivetrainId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.CombustionEngineCar)
            .WithOne(cec => cec.IdNavigation)
            .HasForeignKey<CombustionEngineCar>(cec => cec.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.ElectricCar)
            .WithOne(ec => ec.IdNavigation)
            .HasForeignKey<ElectricCar>(ec => ec.Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.CarAdvertisements)
            .WithOne(ca => ca.Car)
            .HasForeignKey(ca => ca.CarId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}