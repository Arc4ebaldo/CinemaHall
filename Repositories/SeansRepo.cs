using test2.DTO;
using test2.Models;

namespace test2.Repositories;

public class SeansRepo {
    private BaseDbContext context;

    public SeansRepo () {
        this.context = new();
    }

    public void Create(Sean seans) {
        context.Seans.Add(seans);
        context.SaveChanges();
    }

    public SeansDTO GetById(int id) {
        return new SeansDTO(context.Seans.Find(id));
    }

    public void Update(Sean updatedSeans) {
        context.Seans.Update(updatedSeans);
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Seans.Remove(context.Seans.Find(id));
        context.SaveChanges();
    }
}