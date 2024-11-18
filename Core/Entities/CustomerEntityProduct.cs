namespace Core.Entities;

public class CustomerEntityProduct
{
    public int Id { get; set; }
    public int EntityProductId { get; set; }
    public int CustomerEntityId { get; set; }
    public EntityProduct EntityProduct { get; set; } = null!;
    public CustomerEntity CustomerEntity { get; set; } = null!;
}
