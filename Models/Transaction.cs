using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Transaction
{
    public Transaction()
    {
    }

    public Transaction(DateTime? dateTime, string? type, int? amount)
    {
        DateTime = dateTime;
        Type = type;
        Amount = amount;
    }

    public Transaction(int id, DateTime? dateTime, string? type, int? amount)
    {
        Id = id;
        DateTime = dateTime;
        Type = type;
        Amount = amount;
    }

    [Key]
    public int Id { get; set; }
    public DateTime? DateTime { get; set; }
    public string? Type { get; set; }
    public int? Amount { get; set; }
}