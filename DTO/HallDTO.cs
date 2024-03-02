using test2.Models;

namespace test2.DTO;

public class HallDTO(Hall hall)
{
    public string Id { get; set; } = hall.Id.ToString();
    public string? Capacity { get; set; } = hall.Capasity.ToString();
    public string? Name { get; set; } = hall.Name;

    public Hall ToHall() {
        return new Hall(
            int.Parse(Id),
            Name,
            int.Parse(Capacity)
            );
    }
}