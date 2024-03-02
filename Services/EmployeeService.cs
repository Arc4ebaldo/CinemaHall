using test2.DTO;
using test2.Repositories;

namespace test2.Services;

public class EmployeeService
{

    private EmployeeRepo Repo;
    public EmployeeService()
    {
        this.Repo = new();
    }

    public void CreateEmployee(EmployeeDTO newEmployee)
    {
        Repo.Create(newEmployee.ToEmployee());
    }

    public EmployeeDTO? GetEmployeeById(int id)
    {
        return new EmployeeDTO(Repo.GetById(id));
    }

    public EmployeeDTO? GetEmployeeByLogin(string login)
    {
        string[] loginArr = login.Split(" ");
        return new EmployeeDTO(Repo.GetByFirstnameAndLastname(loginArr[0], loginArr[1]));
    }

    public List<EmployeeDTO> GetAllEmployees()
    {
        List<EmployeeDTO> employees = new();
        foreach (var employee in Repo.GetAll())
        {
            employees.Add(new EmployeeDTO(employee));
        }
        return employees;
    }

    public void UpdateEmployee(EmployeeDTO updatedEmployee)
    {
        Repo.Update(updatedEmployee.ToEmployee());
    }

    

    public void DeleteEmployeeById(int id)
    {
        Repo.DeleteById(id);
    }
}