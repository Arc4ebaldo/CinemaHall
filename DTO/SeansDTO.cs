using test2.Models;

namespace test2.DTO;

public class SeansDTO {
    public string StartDatetime {get; set;}
    public string Duration {get; set;}
    public string HallName {get; set;}
    public string FilmName {get; set;}
    public List<Ticket> TicketList {get; set;}

    public SeansDTO (Sean seans) {
        if (seans is null) {
            return;
        }
        this.StartDatetime = seans.StartDatetime.ToString();
        this.Duration = seans.Duration.ToString();
        this.HallName = seans.Hall.Namy;
        this.FilmName = seans.Film.Title;
        this.TicketList = seans.Tickets.ToList();
    }
}