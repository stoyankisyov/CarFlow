using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFlow.Infrastructure.EntityConfigurations;

public class EuroStandardConfiguration : IEntityTypeConfiguration<EuroStandard>
{
    public void Configure(EntityTypeBuilder<EuroStandard> builder)
    {
        builder.ToTable(nameof(EuroStandard));

        builder.HasKey(es => es.Id);

        builder.Property(es => es.Id)
            .ValueGeneratedOnAdd();

        builder.Property(es => es.Name)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasMany(es => es.CombustionEngineCars)
            .WithOne(cec => cec.EuroStandard)
            .HasForeignKey(cec => cec.EuroStandardId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}