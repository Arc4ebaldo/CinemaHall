using test2.Models;

namespace test2.DTO;

public class TicketDTO {
    public string Id {get; set;}
    public string Valid {get; set;}
    public string Price {get; set;}
    public string SeatAdress {get; set;}
    public Seans Seans {get; set;}

    public TicketDTO (Ticket? ticket) {
        this.Id = ticket.Id.ToString();
        this.Valid = ticket.Valid.Value ? "Действителен" : "Не действителен";
        this.Price = ticket.Price.ToString();
        this.SeatAdress = ticket.SeatPosition.ToString();
        this.Seans = ticket.Seans;
    }

    public Ticket ToTicket() {
        return new Ticket(
            int.Parse(Id),
            Valid.Equals("Действителен"),
            int.Parse(Price),
            SeatAdress,
            Seans
        );
    }
}