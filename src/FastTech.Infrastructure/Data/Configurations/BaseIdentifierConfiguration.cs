using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FastTech.Domain.Entities.Interfaces;

namespace FastTech.Infrastructure.Data.Configurations;

public abstract class BaseIdentifierConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IIdentifier
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property<Guid>("Id")
                .ValueGeneratedNever()
                .IsRequired();
    }
}