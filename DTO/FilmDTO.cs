using test2.Models;

namespace test2.DTO;
public class FilmDTO
{
    public string Title {get; set;}
    public string Director {get; set;}
    public string Genre {get; set;}
    public string Duration {get; set;}
    public string ReleaseYear {get; set;}
    public string Description {get; set;}

    public FilmDTO(Film? film)
    {
        if (film is null) {
            return;
        }
        this.Title = film.Title;
        this.Director = film.Director;
        this.Genre = film.Genre;
        this.Duration = film.Duration.ToString();
        this.ReleaseYear = film.ReleaseYear.ToString();
        this.Description = film.Descript;
    }
}