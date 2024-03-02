using test2.Models;

namespace test2.DTO;

public class EmployeeDTO
{
    public string Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Role { get; set; }

    public EmployeeDTO(Employee employee)
    {
        Id = employee.Id.ToString();
        FirstName = employee.FirstName;
        LastName = employee.LastName;
        Role = employee.Role;
    }

    public EmployeeDTO(string? firstName, string? lastName, string? role)
    {
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    public EmployeeDTO(string id, string? firstName, string? lastName, string? role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    internal Employee ToEmployee()
    {
        return new Employee(
            int.Parse(Id),
            FirstName,
            LastName,
            Role
        );
    }
}