using test2.DTO;
using test2.Models;

namespace test2.Repositories;

public class EmployeeRepo {
    private BaseDbContext context;

    public EmployeeRepo()
    {
        this.context = new();
    }

    public EmployeeDTO? GetById(int id) {
        return new EmployeeDTO(context.Employees.Find(id));
    }

    public EmployeeDTO? GetByFirstnameAndLastname (string firstname, string lastname) {
        return new EmployeeDTO(context.Employees
            .Where(e => e.FirstName == firstname && e.LastName == lastname)
            .First());
    }
}