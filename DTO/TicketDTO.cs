using test2.Models;
using test2.Repositories;
using test2.Services;

namespace test2.DTO;

public class TicketDTO
{
    private SeansRepo seansRepo = new();
    public string Id { get; set; }
    public string Valid { get; set; }
    public string Price { get; set; }
    public string SeatAdress { get; set; }
    public string SeansId { get; set; }

    public TicketDTO(Ticket? ticket)
    {
        this.Id = ticket.Id.ToString();
        this.Valid = ticket.Valid.Value ? "Действителен" : "Не действителен";
        this.Price = ticket.Price.ToString();
        this.SeatAdress = ticket.SeatPosition.ToString();
        this.SeansId = ticket.Seans.Id.ToString();
    }

    public TicketDTO(string id, string valid, string price, string seatAdress, string seansId)
    {
        Id = id;
        Valid = valid;
        Price = price;
        SeatAdress = seatAdress;
        SeansId = seansId;
    }

    public TicketDTO(string valid, string price, string seatAdress, string seansId)
    {
        Valid = valid;
        Price = price;
        SeatAdress = seatAdress;
        SeansId = seansId;
    }

    public Ticket ToTicket()
    {
        if (Id is null) {
            return new Ticket(
            Valid.Equals("Действителен"),
            int.Parse(Price),
            SeatAdress,
            seansRepo.GetById(int.Parse(SeansId))
        );
        }
        return new Ticket(
            int.Parse(Id),
            Valid.Equals("Действителен"),
            int.Parse(Price),
            SeatAdress,
            seansRepo.GetById(int.Parse(SeansId))
        );
    }
}