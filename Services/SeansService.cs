using test2.DTO;
using test2.Repositories;

namespace test2.Services;

public class SeansService
{
    private SeansRepo Repo;

    public SeansService()
    {
        this.Repo = new();
    }

    public void CreateSeans(SeansDTO newSeans)
    {
        Repo.Create(newSeans.ToSeans());
    }

    public SeansDTO? GetSeansById(int id)
    {
        return new SeansDTO(Repo.GetById(id));
    }

    public List<SeansDTO> GetAllSeanses()
    {
        List<SeansDTO> seanses = new();
        foreach (var seans in Repo.GetAll())
        {
            seanses.Add(new SeansDTO(seans));
        }
        return seanses;
    }

    public void UpdateSeans(SeansDTO updatedSeans)
    {
        Repo.Update(updatedSeans.ToSeans());
    }

    public void DeleteSeansById(int id)
    {
        Repo.DeleteById(id);
    }
}