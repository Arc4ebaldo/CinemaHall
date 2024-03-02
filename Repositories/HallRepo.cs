using test2.Models;

namespace test2.Repositories;

public class HallRepo {
    private ApplicationContext context;

    public HallRepo () {
        this.context = new();
    }

    public void Create(Hall hall) {
        context.Halls.Add(hall);
        context.SaveChanges();
    }

    public Hall? GetById(int id) {
        return context.Halls.Find(id);
    }

    public IEnumerable<Hall> GetAll() {
        return context.Halls.AsEnumerable();
    }

    public void Update(Hall hall) {
        context.Halls.Update(hall);
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Halls.Remove(context.Halls.Find(id));
        context.SaveChanges();
    }
}