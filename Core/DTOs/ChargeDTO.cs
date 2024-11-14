namespace Core.DTOs;

public class ChargeDTO
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
    public string TransactionDate { get; set; } = string.Empty;
}
