using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Film
{
    public Film()
    {
    }

    public Film(string? title, string? director, string? genre, TimeSpan duration, DateOnly releaseDate, string? description)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Duration = duration;
        ReleaseDate = releaseDate;
        Description = description;
    }

    public Film(int id, string? title, string? director, string? genre, TimeSpan duration, DateOnly releaseDate, string? description)
    {
        Id = id;
        Title = title;
        Director = director;
        Genre = genre;
        Duration = duration;
        ReleaseDate = releaseDate;
        Description = description;
    }

    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Director { get; set; }
    public string? Genre { get; set; }
    public TimeSpan? Duration { get; set; }
    public DateOnly? ReleaseDate { get; set; }
    public string? Description { get; set; }


}