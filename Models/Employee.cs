using System.ComponentModel.DataAnnotations;

namespace test2.Models;

public class Employee
{
    public Employee()
    {
    }

    public Employee(string? firstName, string? lastName, string? role)
    {
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    public Employee(int id, string? firstName, string? lastName, string? role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    [Key]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Role { get; set; }
}