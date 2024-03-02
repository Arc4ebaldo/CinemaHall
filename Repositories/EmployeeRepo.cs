using test2.Models;

namespace test2.Repositories;

public class EmployeeRepo
{
    private ApplicationContext context;

    public EmployeeRepo()
    {
        this.context = new();
    }

    public void Create(Employee newEmployee)
    {
        context.Employees.Add(newEmployee);
        context.SaveChanges();
    }

    public Employee? GetById(int id)
    {
        return context.Employees.Find(id);
    }

    public Employee? GetByFirstnameAndLastname(string firstname, string lastname)
    {
        return context.Employees
            .Where(e => e.FirstName == firstname && e.LastName == lastname)
            .First();
    }

    public IEnumerable<Employee> GetAll()
    {
        return context.Employees.AsEnumerable();
    }

    public void Update(Employee updatedEmployee)
    {
        context.Update(updatedEmployee);
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Employees.Remove(context.Employees.Find(id));
    }
}