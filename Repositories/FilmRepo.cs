using test2.DTO;
using test2.Models;
namespace test2.Repositories;

public class FilmRepo {
    BaseDbContext context;

    public FilmRepo()
    {
        this.context = new BaseDbContext();
    }

    public void Create(Film newFilm) {
        context.Films.Add(newFilm);
        context.SaveChanges();
    }

    public FilmDTO? GetById(int id) {
        return new FilmDTO(context.Films.Find(id));
    }

    public void Update(Film updatedFilm) {
        context.Films.Update(updatedFilm);
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Films.Remove(context.Films.Find(id));
        context.SaveChanges();
    }
}