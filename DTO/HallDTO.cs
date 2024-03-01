using test2.Models;

namespace test2.DTO;

public class HallDTO {
    public string? Capacity {get; set;}
    public string? Name {get; set;}
    public List<Sean>? SeansList {get; set;}

    public HallDTO (Hall? hall) {
        if (hall is null) {
            return;
        }
        this.Capacity = hall.Capacity.ToString();
        this.Name = hall.Namy;
        this.SeansList = hall.Seans.ToList();
    }
}