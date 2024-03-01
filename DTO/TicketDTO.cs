using test2.Models;

namespace test2.DTO;

public class TicketDTO {
    public string Status {get; set;}
    public string Price {get; set;}
    public string SeatAdress {get; set;}
    public string FilmName {get; set;}

    public TicketDTO (Ticket ticket) {
        if (ticket is null) {
            return;
        }
        this.Status = ticket.Statue.Value ? "Действителен" : "Не действителен";
        this.Price = ticket.Price.ToString();
        this.SeatAdress = ticket.Seat.ToString();
        this.FilmName = ticket.Seans.Film.Title;
    }
}