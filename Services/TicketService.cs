using test2.DTO;
using test2.Models;
using test2.Repositories;

namespace test2.Services;

public class TicketService {
    private TicketRepo Repo;

    public TicketService()
    {
        this.Repo = new();
    }

    public void CreateTicket(TicketDTO newTicket) {
        using (var context = new ApplicationContext()) {
            Seans? seans = context.Seanses.Find(int.Parse(newTicket.SeansId));
            Ticket ticket = new Ticket(
                newTicket.Valid.Equals("Действителен"),
                int.Parse(newTicket.Price),
                newTicket.SeatAdress,
                seans
            );
            context.Tickets.Add(ticket);
            context.SaveChanges();
        }
    }

    public TicketDTO GetTicketById(int id) {
        return new TicketDTO(Repo.GetById(id));
    }

    public List<TicketDTO> GetAllTickets() {
        List<TicketDTO> tickets = new();
        foreach (var ticket in Repo.GetAll())
        {
            tickets.Add(new TicketDTO(ticket));
        }
        return tickets;
    }

    public void UpdateTicket(TicketDTO newTicket) {
        Repo.Update(newTicket.ToTicket());
    }

    public void DeleteTicketById(int id) {
        Repo.DeleteById(id);
    }
}