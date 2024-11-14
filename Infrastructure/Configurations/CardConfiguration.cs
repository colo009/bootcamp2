using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> entity)
    {
        entity.HasKey(x => x.Id);

        entity
            .Property(x => x.Number)
            .IsRequired();

        entity
            .Property(x => x.Type)
            .IsRequired();

        entity
            .Property(x => x.Limit)
            .IsRequired();

        entity
            .Property(x => x.ExpirationDatetime)
            .IsRequired();

        entity
            .Property(x => x.InterestRate)
            .IsRequired();

        entity
            .HasOne(x => x.Customer)
            .WithMany(x => x.Cards)
            .HasForeignKey(x => x.CustomerId);

        entity
            .HasMany(x => x.Charges)
            .WithOne(x => x.Card)
            .HasForeignKey(x => x.CardId);
    }
}
