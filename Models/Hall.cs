using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Hall
{
    public Hall()
    {
    }

    public Hall(string? name, int? capasity)
    {
        Name = name;
        Capasity = capasity;
    }

    public Hall(int id, string? name, int? capasity)
    {
        Id = id;
        Name = name;
        Capasity = capasity;
    }

    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? Capasity { get; set; }
}