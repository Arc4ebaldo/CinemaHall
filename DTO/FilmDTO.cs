using test2.Models;

namespace test2.DTO;
public class FilmDTO
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public string Duration { get; set; }
    public string ReleaseDate { get; set; }
    public string Description { get; set; }

    public FilmDTO(Film film)
    {
        Id = film.Id.ToString();
        Title = film.Title;
        Director = film.Director;
        Genre = film.Genre;
        Duration = film.Duration.ToString();
        ReleaseDate = film.ReleaseDate.ToString();
        Description = film.Description;
    }

    public FilmDTO(string id, string title, string director, string genre, string duration, string releaseDate, string description)
    {
        Id = id;
        Title = title;
        Director = director;
        Genre = genre;
        Duration = duration;
        ReleaseDate = releaseDate;
        Description = description;
    }

    public FilmDTO(string title, string director, string genre, string duration, string releaseDate, string description)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Duration = duration;
        ReleaseDate = releaseDate;
        Description = description;
    }

    public Film ToFilm() {
        if (Id is null) {
            return new Film(
            Title,
            Director,
            Genre,
            TimeSpan.Parse(Duration),
            DateOnly.Parse(ReleaseDate),
            Description
        );
        }
        return new Film(
            int.Parse(Id),
            Title,
            Genre,
            Director,
            TimeSpan.Parse(Duration),
            DateOnly.Parse(ReleaseDate),
            Description
        );
    }
}