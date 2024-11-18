using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .HasIndex(x => new { x.CustomerId, x.EntityId })
            .IsUnique();

        entity
            .HasOne(x => x.Customer)
            .WithMany(x => x.CustomerEntities)
            .HasForeignKey(x => x.CustomerId);

        entity
            .HasOne(x => x.Entity)
            .WithMany(x => x.CustomerEntities)
            .HasForeignKey(x => x.EntityId);
    }
}
