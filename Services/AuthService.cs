using test2.DTO;

namespace test2.Services;

public class AuthService {
    private const string Password = "123456";
    private EmployeeService employeeService;

    public AuthService()
    {
        this.employeeService = new();
    }

    public bool IsCorrect(string login, string password) {
        EmployeeDTO? employee = employeeService
                                    .GetEmployeeByLogin(login);
        if (employee is null) {
            return false;
        }
        return password.Equals(Password);
    }
}