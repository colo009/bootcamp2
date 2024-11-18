using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EntityProductConfiguration : IEntityTypeConfiguration<EntityProduct>
{
    public void Configure(EntityTypeBuilder<EntityProduct> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .Property(x => x.Name)
            .IsRequired();

        entity
            .HasOne(x => x.Entity)
            .WithMany(x => x.EntityProducts)
            .HasForeignKey(x => x.EntityId);

        entity
            .HasMany(x => x.CustomerEntityProducts)
            .WithOne(x => x.EntityProduct)
            .HasForeignKey(x => x.EntityProductId);
    }
}
