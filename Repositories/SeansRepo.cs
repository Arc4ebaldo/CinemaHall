using Microsoft.EntityFrameworkCore;
using test2.Models;

namespace test2.Repositories;

public class SeansRepo
{
    private ApplicationContext context;
    public SeansRepo()
    {
        this.context = new();
    }

    public void Create(Seans seans)
    {
        context.Seanses.Add(seans);
        context.SaveChanges();
    }

    public Seans? GetById(int id)
    {
        return context.Seanses.Find(id);
    }

    public IEnumerable<Seans> GetAll()
    {
        return context.Seanses
            .Include(s => s.Hall)
            .Include(s => s.Film)
            .AsEnumerable();
    }

    public void Update(Seans updatedSeans)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
    {
        context.Seanses.Remove(context.Seanses.Find(id));
        context.SaveChanges();
    }
}