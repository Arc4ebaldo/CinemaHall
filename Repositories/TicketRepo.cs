using test2.Models;

namespace test2.Repositories;

public class TicketRepo {
    private ApplicationContext context;

    public TicketRepo () {
        this.context = new();
    }

    public void Create(Ticket ticket) {
        context.Tickets.Add(ticket);
        context.SaveChanges();
    }

    public Ticket? GetById(int id) {
        return context.Tickets.Find(id);
    }

    public IEnumerable<Ticket> GetAll() {
        return context.Tickets.AsEnumerable();
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