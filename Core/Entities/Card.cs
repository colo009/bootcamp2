namespace Core.Entities;

public class Card
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal Limit { get; set; }
    public DateTime ExpirationDatetime { get; set; }
    public decimal InterestRate { get; set; }
    public decimal Debt { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public List<Charge> Charges { get; set; } = [];
}
