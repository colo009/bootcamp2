using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .Property(x => x.Number)
            .IsRequired();

        entity
            .Property(x => x.Balance)
            .IsRequired();

        entity
            .Property(x => x.OpeningDate)
            .IsRequired();

        entity
            .HasOne(x => x.Customer)
            .WithMany(x => x.Accounts)
            .HasForeignKey(x => x.CustomerId);
    }
}