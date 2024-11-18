using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .Property(x => x.FirstName)
            .IsRequired();

        entity
            .HasMany(x => x.Accounts)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        entity
            .HasMany(x => x.Cards)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        entity
            .HasMany(x => x.CustomerEntities)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);
    }
}
