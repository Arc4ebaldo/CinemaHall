using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Ticket
{
    public Ticket()
    {
    }

    public Ticket(bool? valid, int? price, string? seatPosition, Seans seans)
    {
        Valid = valid;
        Price = price;
        SeatPosition = seatPosition;
        Seans = seans;
    }

    public Ticket(int? id, bool? valid, int? price, string? seatPosition, Seans seans)
    {
        Id = id;
        Valid = valid;
        Price = price;
        SeatPosition = seatPosition;
        SeansId = seans.Id;
        Seans = seans;
    }

    [Key]
    public int? Id { get; set; }
    public bool? Valid { get; set; }
    public int? Price { get; set; }
    public string? SeatPosition { get; set; }
    public int SeansId {get; set;}
    public Seans Seans { get; set; }
}