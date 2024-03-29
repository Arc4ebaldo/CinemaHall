using test2.Models;
namespace test2.Repositories;

public class FilmRepo
{
    private ApplicationContext context;
    public FilmRepo()
    {
        this.context = new();
    }

    public void Create(Film newFilm)
    {
        context.Films.Add(newFilm);
        context.SaveChanges();
    }

    public Film? GetById(int id)
    {
        return context.Films.Find(id);
    }

    public IEnumerable<Film> GetAll()
    {
        return context.Films.AsEnumerable();
    }

    public void Update(Film updatedFilm)
    {
        Film? filmToUpdate = context.Films.Find(updatedFilm.Id);
        filmToUpdate.Title = updatedFilm.Title;
        filmToUpdate.Director = updatedFilm.Director;
        filmToUpdate.Genre = updatedFilm.Genre;
        filmToUpdate.Duration = updatedFilm.Duration;
        filmToUpdate.ReleaseDate = updatedFilm.ReleaseDate;
        filmToUpdate.Description = updatedFilm.Description;
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Films.Remove(context.Films.Find(id));
        context.SaveChanges();
    }

    public Film GetByName(string filmName)
    {
        return context.Films
            .Where(f => f.Title == filmName)
            .First();
    }
}