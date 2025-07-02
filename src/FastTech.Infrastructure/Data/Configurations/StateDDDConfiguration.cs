using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FastTech.Domain.Entities;

namespace FastTech.Infrastructure.Data.Configurations;

public class StateDDDConfiguration : IEntityTypeConfiguration<StateDDD>
{
    public void Configure(EntityTypeBuilder<StateDDD> builder)
    {
        builder.HasKey(s => s.DDD);

        builder.Property(s => s.State)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Region)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.DDD)
            .ValueGeneratedNever()
            .IsRequired();
    }
}