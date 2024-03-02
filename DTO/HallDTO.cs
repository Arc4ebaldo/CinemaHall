using test2.Models;

namespace test2.DTO;

public class HallDTO
{
    public HallDTO(Hall hall)
    {
        Id = hall.Id.ToString();
        Capacity = hall.Capasity.ToString();
        Name = hall.Name;
    }

    public HallDTO(string? capacity, string? name)
    {
        Capacity = capacity;
        Name = name;
    }

    public HallDTO(string id, string? capacity, string? name)
    {
        Id = id;
        Capacity = capacity;
        Name = name;
    }

    public string Id { get; set; }
    public string? Capacity { get; set; }
    public string? Name { get; set; }

    public Hall ToHall() {
        return new Hall(
            Name,
            int.Parse(Capacity)
            );
    }
}