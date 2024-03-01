using test2.Models;
using test2.Repositories;

namespace test2.DTO;

public class EmployeeDTO {
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Role { get; set; }

    public EmployeeDTO(Employee employee)
    {
        this.FirstName = employee.FirstName;
        this.LastName = employee.LastName;
        this.Role = employee.Position;
    }
}