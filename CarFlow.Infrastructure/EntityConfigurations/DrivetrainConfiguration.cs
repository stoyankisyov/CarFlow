using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class DrivetrainConfiguration : IEntityTypeConfiguration<Drivetrain>
{
    public void Configure(EntityTypeBuilder<Drivetrain> builder)
    {
        builder.ToTable(nameof(Drivetrain));

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
            .ValueGeneratedOnAdd();

        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(d => d.Name)
            .IsUnique();

        builder.HasMany(d => d.Cars)
            .WithOne(c => c.Drivetrain)
            .HasForeignKey(c => c.DrivetrainId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}