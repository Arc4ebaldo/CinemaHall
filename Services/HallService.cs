using test2.DTO;
using test2.Models;
using test2.Repositories;

namespace test2.Services;

public class HallService
{

    private HallRepo Repo;

    public HallService()
    {
        this.Repo = new();
    }

    public void CreateHall(HallDTO hall)
    {
        Repo.Create(hall.ToHall());
    }

    public HallDTO? GetHallById(int id)
    {
        return new HallDTO(Repo.GetById(id));
    }

    public List<HallDTO> GetAllHalls()
    {
        List<HallDTO> halls = new();
        foreach (var hall in Repo.GetAll())
        {
            halls.Add(new HallDTO(hall));
        }
        return halls;
    }

    public void UpdateHall(HallDTO updatedHall)
    {
        Repo.Update(updatedHall.ToHall());
    }

    public void DeleteHallById(int id)
    {
        Repo.DeleteById(id);
    }

    public Hall GetHallByName(string hallName)
    {
        return Repo.GetByName(hallName);
    }
}