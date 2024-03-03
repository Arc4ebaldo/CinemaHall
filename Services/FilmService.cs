using test2.DTO;
using test2.Models;
using test2.Repositories;

namespace test2.Services;

public class FilmService
{

    private FilmRepo Repo;

    public FilmService()
    {
        this.Repo = new();
    }

    public void CreateFilm(FilmDTO film)
    {
        Repo.Create(film.ToFilm());
    }

    public FilmDTO? GetFilmById(int id)
    {
        return new FilmDTO(Repo.GetById(id));
    }

    public List<FilmDTO> GetAllFilms()
    {
        List<FilmDTO> films = new();
        foreach (var film in Repo.GetAll())
        {
            films.Add(new FilmDTO(film));
        }
        return films;
    }

    public void UpdateFilm(FilmDTO updatedFilm)
    {
        Repo.Update(updatedFilm.ToFilm());
    }

    public void DeleteFilmById(int id)
    {
        Repo.DeleteById(id);
    }

    public FilmDTO GetFilmByName(string filmName)
    {
        return new FilmDTO(Repo.GetByName(filmName));
    }
}