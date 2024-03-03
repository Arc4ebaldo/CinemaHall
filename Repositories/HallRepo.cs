using test2.Models;

namespace test2.Repositories;

public class HallRepo
{
    private ApplicationContext context;
    public HallRepo()
    {
        this.context = new();
    }

    public void Create(Hall hall)
    {
        context.Halls.Add(hall);
        context.SaveChanges();
    }

    public Hall? GetById(int id)
    {
        return context.Halls.Find(id);
    }

    public IEnumerable<Hall> GetAll()
    {
        return context.Halls.AsEnumerable();
    }

    public void Update(Hall updatedHall)
    {
        Hall? hallToUpdate = context.Halls.Find(updatedHall.Id);
        hallToUpdate.Name = updatedHall.Name;
        hallToUpdate.Capasity = updatedHall.Capasity;
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Halls.Remove(context.Halls.Find(id));
        context.SaveChanges();
    }

    internal Hall GetByName(string hallName)
    {
        return context.Halls
            .Where(hall => hall.Name == hallName)
            .First();
    }
}