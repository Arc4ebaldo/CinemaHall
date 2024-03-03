using test2.DTO;
using test2.Models;
using test2.Repositories;

namespace test2.Services;

public class SeansService
{
    private SeansRepo Repo;

    public SeansService()
    {
        this.Repo = new();
    }

    public void CreateSeans(SeansDTO newSeans)
    {
        using (var context = new ApplicationContext())
        {
            Film film = context.Films
                .Where(f => f.Title == newSeans.FilmName).First();
            Hall hall = context.Halls.Where(h => h.Name == newSeans.HallName).First();
            Seans seans = new Seans(
                DateTime.Parse(newSeans.StartDatetime),
                TimeSpan.Parse(newSeans.Duration),
                hall,
                film
            );
            context.Seanses.Add(seans);
            context.SaveChanges();
        }
    }

    public SeansDTO? GetSeansById(int id)
    {
        return new SeansDTO(Repo.GetById(id));
    }

    public List<SeansDTO> GetAllSeanses()
    {
        List<SeansDTO> seanses = new();
        foreach (var seans in Repo.GetAll())
        {
            seanses.Add(new SeansDTO(seans));
        }
        return seanses;
    }

    public void UpdateSeans(SeansDTO updatedSeans)
    {
        using (var context = new ApplicationContext())
        {
            Seans? seansToUpdate = context.Seanses.Find(int.Parse(updatedSeans.Id));
            Film film = context.Films
                .Where(f => f.Title == updatedSeans.FilmName)
                .First();
            Hall hall = context.Halls
                .Where(h => h.Name == updatedSeans.HallName)
                .First();
            seansToUpdate.StartDateTime = DateTime.Parse(updatedSeans.StartDatetime);
            seansToUpdate.Duration = TimeSpan.Parse(updatedSeans.Duration);
            seansToUpdate.HallId = hall.Id;
            seansToUpdate.Hall = hall;
            seansToUpdate.FilmId = film.Id;
            seansToUpdate.Film = film;
            context.SaveChanges();
        }
    }

    public void DeleteSeansById(int id)
    {
        Repo.DeleteById(id);
    }
}