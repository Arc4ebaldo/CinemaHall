using test2.Models;
using test2.Repositories;
using test2.Services;

namespace test2.DTO;

public class SeansDTO
{
    private HallService hallService = new();
    private FilmService filmService = new();
    public string Id { get; set; }
    public string StartDatetime { get; set; }
    public string Duration { get; set; }
    public string HallName { get; set; }
    public string FilmName { get; set; }

    public SeansDTO(Seans seans)
    {
        Id = seans.Id.ToString();
        StartDatetime = seans.StartDateTime.ToString();
        Duration = seans.Duration.ToString();
        HallName = seans.Hall.Name;
        FilmName = seans.Film.Title;
    }

    public SeansDTO(string startDatetime, string duration, string hallName, string filmName)
    {
        StartDatetime = startDatetime;
        Duration = duration;
        HallName = hallName;
        FilmName = filmName;
    }

    public SeansDTO(string id, string startDatetime, string duration, string hallName, string filmName)
    {
        Id = id;
        StartDatetime = startDatetime;
        Duration = duration;
        HallName = hallName;
        FilmName = filmName;
    }

    internal Seans ToSeans()
    {
        if (Id is null) {
            return new Seans(
            DateTime.Parse(Duration),
            TimeSpan.Parse(Duration),
            hallService.GetHallByName(HallName).ToHall(),
            filmService.GetFilmByName(FilmName).ToFilm()
        );
        }
        return new Seans(
            int.Parse(Id),
            DateTime.Parse(Duration),
            TimeSpan.Parse(Duration),
            hallService.GetHallByName(HallName).ToHall(),
            filmService.GetFilmByName(FilmName).ToFilm()
        );
    }
}