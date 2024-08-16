using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class ElectricCarConfiguration : IEntityTypeConfiguration<ElectricCar>
{
    public void Configure(EntityTypeBuilder<ElectricCar> builder)
    {
        builder.ToTable(nameof(ElectricCar));

        builder.Property(ec => ec.Horsepower)
            .IsRequired();

        builder.Property(ec => ec.Torque)
            .IsRequired();

        builder.Property(ec => ec.BatteryCapacity)
            .IsRequired();

        builder.Property(ec => ec.Range)
            .IsRequired();

        builder.Property(ec => ec.MotorCount)
            .IsRequired();

        builder.HasOne(ec => ec.IdNavigation)
            .WithOne(c => c.ElectricCar)
            .HasForeignKey<ElectricCar>(ec => ec.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}