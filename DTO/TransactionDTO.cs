using test2.Models;

namespace test2.DTO;

public class TransactionDTO(Transaction transaction)
{
    public string Id { get; set; } = transaction.Id.ToString();
    public string DateTime { get; set; } = transaction.DateTime.ToString();
    public string Type { get; set; } = transaction.Type;
    public string Amount { get; set; } = transaction.Amount.ToString();

    public Transaction ToTransaction() {
        return new Transaction(
            int.Parse(Id),
            System.DateTime.Parse(DateTime),
            Type,
            int.Parse(Amount)
        );
    }
}