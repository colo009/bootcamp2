namespace Core.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Account> Accounts { get; set; } = [];
    public List<Card> Cards { get; set; } = [];
    public List<CustomerEntity> CustomerEntities { get; set; } = [];
}
