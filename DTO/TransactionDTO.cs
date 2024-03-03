using test2.Models;

namespace test2.DTO;

public class TransactionDTO
{
    public string Id { get; set; }
    public string DateTime { get; set; }
    public string Type { get; set; }
    public string Amount { get; set; }

    public TransactionDTO(Transaction transaction)
    {
        Id = transaction.Id.ToString();
        DateTime = transaction.DateTime.ToString();
        Type = transaction.Type;
        Amount = transaction.Amount.ToString();
    }

    public TransactionDTO(string dateTime, string type, string amount)
    {
        DateTime = dateTime;
        Type = type;
        Amount = amount;
    }

    public TransactionDTO(string id, string dateTime, string type, string amount)
    {
        Id = id;
        DateTime = dateTime;
        Type = type;
        Amount = amount;
    }

    public Transaction ToTransaction() {
        if (Id is null) {
            return new Transaction(
            System.DateTime.Parse(DateTime),
            Type,
            int.Parse(Amount)
        );
        }
        return new Transaction(
            int.Parse(Id),
            System.DateTime.Parse(DateTime),
            Type,
            int.Parse(Amount)
        );
    }
}