using test2.Models;

namespace test2.DTO;
public class FilmDTO(Film film)
{
    public string Id { get; set; } = film.Id.ToString();
    public string Title { get; set; } = film.Title;
    public string Director { get; set; } = film.Director;
    public string Genre { get; set; } = film.Genre;
    public string Duration { get; set; } = film.Duration.ToString();
    public string ReleaseDate { get; set; } = film.ReleaseDate.ToString();
    public string Description { get; set; } = film.Description;

    public Film ToFilm() {
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