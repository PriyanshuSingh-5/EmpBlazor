using BlazorEmpwage.Data;
using System.Collections.Generic;

namespace BlazorEmpwage.Services
{
    public interface IEmpServices
    {
        string Create(Employee objCustomer);
        string DeleteEmployee(Employee objcustomer);
        List<Employee> GetEmployee();
        Employee GetEmployeeByID(int id);
        string UpdateEmployee(Employee objcustomer);
    }
}