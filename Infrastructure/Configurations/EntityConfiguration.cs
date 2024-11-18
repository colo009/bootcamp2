using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EntityConfiguration : IEntityTypeConfiguration<Entity>
{
    public void Configure(EntityTypeBuilder<Entity> entity)
    {
        entity.HasKey(e => e.Id);

        entity
            .Property(x => x.Name)
            .IsRequired();

        entity
            .HasMany(x => x.CustomerEntities)
            .WithOne(x => x.Entity)
            .HasForeignKey(x => x.EntityId);

        entity
            .HasMany(x => x.EntityProducts)
            .WithOne(x => x.Entity)
            .HasForeignKey(x => x.EntityId);
    }
}
