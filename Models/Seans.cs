using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Seans
{
    public Seans()
    {
    }

    public Seans(DateTime? startDateTime, TimeSpan? duration, Hall hall, Film film)
    {
        StartDateTime = startDateTime;
        Duration = duration;
        HallId = hall.Id;
        Hall = hall;
        FilmId = film.Id;
        Film = film;
    }

    public Seans(int id, DateTime? startDateTime, TimeSpan? duration, Hall hall, Film film)
    {
        Id = id;
        StartDateTime = startDateTime;
        Duration = duration;
        HallId = hall.Id;
        Hall = hall;
        FilmId = film.Id;
        Film = film;
    }

    [Key]
    public int Id { get; set; }
    public DateTime? StartDateTime { get; set; }
    public TimeSpan? Duration { get; set; }
    public int HallId {get; set;}
    public Hall Hall { get; set; }
    public int FilmId {get;set;}
    public Film Film { get; set; }
}