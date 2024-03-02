using test2.DTO;
using test2.Repositories;

namespace test2.Services;

public class EmployeeService {
    
    private EmployeeRepo Repo;
    public EmployeeService() {
        this.Repo = new();
    }

    public EmployeeDTO? GetEmployeeById(int id) {
        return new EmployeeDTO(Repo.GetById(id));
    }

    public EmployeeDTO? GetEmployeeByLogin(string login) {
        string[] loginArr = login.Split(" ");
        return new EmployeeDTO(Repo.GetByFirstnameAndLastname(loginArr[0], loginArr[1]));
    }
}