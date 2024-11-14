namespace Core.Entities;

public class Charge
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }

    public int CardId { get; set; }
    public Card Card { get; set; } = null!;
}
