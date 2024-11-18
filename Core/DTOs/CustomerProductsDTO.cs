namespace Core.DTOs;

public class CustomerProductsDTO
{
    public string FullName { get; set; } = string.Empty;
    public List<EntityProductsDTO> Products { get; set; } = [];
}

public class EntityProductsDTO
{
    public string EntityName { get; set; } = string.Empty;
    public List<ProductDTO> Products { get; set; } = [];
}

public class ProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
