namespace Core.Entities;

public class Entity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<CustomerEntity> CustomerEntities { get; set; } = [];
    public List<EntityProduct> EntityProducts { get; set; } = [];
}
