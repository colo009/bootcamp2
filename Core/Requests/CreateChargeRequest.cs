namespace Core.Requests;

public class CreateChargeRequest
{
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public int CardId { get; set; }
}
