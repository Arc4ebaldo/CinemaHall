using test2.DTO;
using test2.Models;
using test2.Repositories;

namespace test2.Services;

public class TicketService {
    private TicketRepo Repo;

    public TicketService(TicketRepo repo)
    {
        Repo = repo;
    }

    public void CreateTicket(TicketDTO newTicket) {
        Repo.Create(newTicket.ToTicket());
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

    public void DeleteById(int id) {
        Repo.DeleteById(id);
    }
}