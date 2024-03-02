using test2.Models;
using test2.Repositories;

namespace test2.DTO;

public class SeansDTO(Seans seans)
{
    public string Id {get; set;} = seans.Id.ToString();
    public string StartDatetime { get; set; } = seans.StartDateTime.ToString();
    public string Duration { get; set; } = seans.Duration.ToString();
    public Hall Hall { get; set; } = seans.Hall;
    public Film Film { get; set; } = seans.Film;

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