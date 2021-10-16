using System.Collections.Generic;

namespace BlazorEmpwage.Data
{
    public interface IEmpDataAccessLayer
    {
        string ConnectionStringName { get; set; }

        void AddEmployee(Employee Customer);
        void DeleteEmployee(int? id);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeData(int? id);
        void UpdateEmployee(Employee Customer);
    }
}