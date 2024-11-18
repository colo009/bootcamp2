namespace Core.Entities;

public class EntityProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int EntityId { get; set; }
    public Entity Entity { get; set; } = null!;
    public List<CustomerEntityProduct> CustomerEntityProducts { get; set; } = [];
}
