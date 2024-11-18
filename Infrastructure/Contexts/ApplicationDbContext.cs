using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public partial class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Charge> Charges { get; set; }
    public DbSet<Entity> Entities { get; set; }
    public DbSet<CustomerEntity> CustomersEntities { get; set; }
    public DbSet<EntityProduct> EntitiesProducts { get; set; }
    public DbSet<CustomerEntityProduct> CustomersEntitiesProducts { get; set; }


    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new CardConfiguration());
        modelBuilder.ApplyConfiguration(new ChargeConfiguration());
        modelBuilder.ApplyConfiguration(new EntityConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
        modelBuilder.ApplyConfiguration(new EntityProductConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityProductConfiguration());
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
