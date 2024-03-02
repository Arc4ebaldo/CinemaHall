using test2.Models;
namespace test2.Repositories;

public class FilmRepo {
    private ApplicationContext context;

    public FilmRepo()
    {
        this.context = new ApplicationContext();
    }

    public void Create(Film newFilm) {
        context.Films.Add(newFilm);
        context.SaveChanges();
    }

    public Film? GetById(int id) {
        return context.Films.Find(id);
    }

    public IEnumerable<Film> GetAll() {
        return context.Films.AsEnumerable();
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