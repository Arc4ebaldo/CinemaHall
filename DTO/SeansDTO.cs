using test2.Models;
using test2.Repositories;

namespace test2.DTO;

public class SeansDTO
{
    public string Id {get; set;}
    public string StartDatetime { get; set; }
    public string Duration { get; set; }
    public Hall Hall { get; set; }
    public Film Film { get; set; }

    public SeansDTO(Seans seans)
    {
        Id = seans.Id.ToString();
        StartDatetime = seans.StartDateTime.ToString();
        Duration = seans.Duration.ToString();
        Hall = seans.Hall;
        Film = seans.Film;
    }

    public SeansDTO(string startDatetime, string duration, Hall hall, Film film)
    {
        StartDatetime = startDatetime;
        Duration = duration;
        Hall = hall;
        Film = film;
    }

    public SeansDTO(string id, string startDatetime, string duration, Hall hall, Film film)
    {
        Id = id;
        StartDatetime = startDatetime;
        Duration = duration;
        Hall = hall;
        Film = film;
    }

    internal Seans ToSeans()
    {
        return new Seans(
            int.Parse(Id),
            DateTime.Parse(Duration),
            TimeSpan.Parse(Duration),
            Hall,
            Film
        );
    }
}