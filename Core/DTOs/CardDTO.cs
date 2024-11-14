namespace Core.DTOs;

public class CardDTO
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal Limit { get; set; }
    public string ExpirationDatetime { get; set; } = string.Empty;
    public decimal InterestRate { get; set; }

    public CustomerDTO Customer { get; set; } = new();
}
