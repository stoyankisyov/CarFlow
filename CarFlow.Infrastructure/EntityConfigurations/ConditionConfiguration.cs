using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class ConditionConfiguration : IEntityTypeConfiguration<Condition>
{
    public void Configure(EntityTypeBuilder<Condition> builder)
    {
        builder.ToTable(nameof(Condition));

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.HasMany(c => c.CarAdvertisements)
            .WithOne(ca => ca.Condition)
            .HasForeignKey(ca => ca.ConditionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}