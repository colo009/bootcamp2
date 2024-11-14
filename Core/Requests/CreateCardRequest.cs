namespace Core.Requests;

public class CreateCardRequest
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal Limit { get; set; }
    public DateTime ExpirationDatetime { get; set; }
    public decimal InterestRate { get; set; }

    public int CustomerId { get; set; }
}
