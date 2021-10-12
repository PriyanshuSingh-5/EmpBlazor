﻿using BlazorEmpwage.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Services
{
    public class EmpServices
    {
        EmpDataAccessLayer objCustomerDAL = new EmpDataAccessLayer();
        public List<Employee> GetEmployee()
        {
            List<Employee> customers = objCustomerDAL.GetAllEmployee().ToList();
            return customers;
        }
        public string Create(Employee objCustomer)
        {
            objCustomerDAL.AddEmployee(objCustomer);
            return "Added Successfully";
        }

        public Employee GetEmployeeByID(int id)
        {
            Employee customer = objCustomerDAL.GetEmployeeData(id);
            return customer;
        }
        public string UpdateEmployee(Employee objcustomer)
        {
            objCustomerDAL.UpdateEmployee(objcustomer);
            return "Update Successfully";
        }
        public string DeleteEmployee(Employee objcustomer)
        {
            objCustomerDAL.DeleteEmployee(objcustomer.EmployeeId);
            return "Delete Successfully";
        }
    }
}
