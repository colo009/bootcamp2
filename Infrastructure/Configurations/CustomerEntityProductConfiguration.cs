using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CustomerEntityProductConfiguration : IEntityTypeConfiguration<CustomerEntityProduct>
{
    public void Configure(EntityTypeBuilder<CustomerEntityProduct> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .HasIndex(x => new { x.CustomerEntityId, x.EntityProductId })
            .IsUnique();

        entity
            .HasOne(x => x.CustomerEntity)
            .WithMany(x => x.CustomerEntityProducts)
            .HasForeignKey(x => x.CustomerEntityId);

        entity
            .HasOne(x => x.EntityProduct)
            .WithMany(x => x.CustomerEntityProducts)
            .HasForeignKey(x => x.EntityProductId);
    }
}
