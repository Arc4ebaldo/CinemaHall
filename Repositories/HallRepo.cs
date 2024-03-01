using test2.DTO;
using test2.Models;

namespace test2.Repositories;

public class HallRepo {
    private BaseDbContext context;

    public HallRepo () {
        this.context = new();
    }

    public void Create(Hall hall) {
        context.Halls.Add(hall);
        context.SaveChanges();
    }

    public HallDTO? GetById(int id) {
        return new HallDTO(context.Halls.Find(id));
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