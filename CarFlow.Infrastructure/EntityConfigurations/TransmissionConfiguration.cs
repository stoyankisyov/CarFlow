using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.ToTable(nameof(Transmission));

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(t => t.Name)
            .IsUnique();

        builder.HasMany(t => t.TransmissionVariants)
            .WithOne(tv => tv.Transmission)
            .HasForeignKey(tv => tv.TransmissionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}