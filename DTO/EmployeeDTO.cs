using test2.Models;

namespace test2.DTO;

public class EmployeeDTO(Employee employee)
{
    public string Id { get; set; } = employee.Id.ToString();
    public string? FirstName { get; set; } = employee.FirstName;
    public string? LastName { get; set; } = employee.LastName;
    public string? Role { get; set; } = employee.Role;
}