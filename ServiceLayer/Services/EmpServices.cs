using BlazorEmpwage.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Services
{
    public class EmpServices : IEmpServices
    {
        private readonly IEmpDataAccessLayer _db;
        public EmpServices(IEmpDataAccessLayer db)
        {
            _db = db;
        }


        public List<Employee> GetEmployee()
        {
            List<Employee> customers = _db.GetAllEmployee().ToList();
            // List<Employee> customers = objCustomerDAL.GetAllEmployee().ToList();
            return customers;
        }
        public string Create(Employee objCustomer)
        {
            _db.AddEmployee(objCustomer);
            // objCustomerDAL.AddEmployee(objCustomer);
            return "Added Successfully";
        }

        public Employee GetEmployeeByID(int id)
        {
            Employee customer = _db.GetEmployeeData(id);
            // Employee customer = objCustomerDAL.GetEmployeeData(id);
            return customer;
        }
        public string UpdateEmployee(Employee objcustomer)
        {
            _db.UpdateEmployee(objcustomer);
            //objCustomerDAL.UpdateEmployee(objcustomer);
            return "Update Successfully";
        }
        public string DeleteEmployee(Employee objcustomer)
        {
            _db.DeleteEmployee(objcustomer.EmployeeId);
            //objCustomerDAL.DeleteEmployee(objcustomer.EmployeeId);
            return "Delete Successfully";
        }
    }
}
