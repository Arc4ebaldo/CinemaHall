using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using test2.DTO;
using test2.Models;
using test2.Repositories;

public class AuthService {
    private const string Password = "123456";
    private EmployeeRepo employeeRepo;

    public AuthService()
    {
        this.employeeRepo = new();
    }

    public bool IsCorrect(string login, string password) {
        string[] FnameLname = login.Split(" ");
        EmployeeDTO? employee = employeeRepo.GetByFirstnameAndLastname(FnameLname[0], FnameLname[1]);
        if (employee is null) {
            return false;
        }
        return password.Equals(Password);
    }
}