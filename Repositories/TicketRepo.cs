using test2.DTO;
using test2.Models;

namespace test2.Repositories;

public class TicketRepo {
    private BaseDbContext context;

    public TicketRepo () {
        this.context = new();
    }

    public void Create(Ticket ticket) {
        context.Tickets.Add(ticket);
        context.SaveChanges();
    }

    public TicketDTO GetById(int id) {
        return new TicketDTO(context.Tickets.Find(id));
    }

    public void Update(Ticket ticket) {
        context.Tickets.Update(ticket);
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Tickets.Remove(context.Tickets.Find(id));
        context.SaveChanges();
    }
}