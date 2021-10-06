﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Data
{
    public class EmpDataAccessLayer
    {
        // string connectionString = "Put Your Connection string here";
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-QJSM3AFE\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True;");

        //public List<Employee>GetEmployees()
        //{
        //    List<Employee> listObj = new List<Employee>();
        //    SqlCommand cmd = new SqlCommand("usp_getEmployee", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    foreach(DataRow dr in dt.Rows)
        //        {
        //        Employee emp = new Employee();
        //        emp.EmployeeId = Convert.ToInt32(dr[0]);
        //        emp.Name = Convert.ToString(dr[1]);
        //        emp.Gender = Convert.ToString(dr[2]);
        //        emp.Department = Convert.ToString(dr[3]);
        //        emp.Notes = Convert.ToString(dr[4]);
        //        listObj.Add(emp);

        //    }


        //    return listObj;
        //}

        string connectionString = "Data Source=LAPTOP-QJSM3AFE\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True;";
        //To View all Customers details    
        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> lstCustomer = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee Emp = new Employee();
                    Emp.EmployeeId = Convert.ToInt32(rdr["EmployeeID"]);
                    Emp.Name = rdr["Name"].ToString();
                    Emp.Gender = rdr["Gender"].ToString();
                    Emp.Department = rdr["Department"].ToString();
                    Emp.Notes = rdr["Notes"].ToString();
                    //Customer.Country = rdr["Country"].ToString();
                    //Emp.City = rdr["City"].ToString();
                    lstCustomer.Add(Emp);
                }
                con.Close();
            }
            return lstCustomer;
        }
        //To Add new Customer record    

        
        public void AddEmployee(Employee Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Department", Customer.Department);
                cmd.Parameters.AddWithValue("@Salary", Customer.Salary);
                cmd.Parameters.AddWithValue("@StartDate", Customer.StartDate);
                cmd.Parameters.AddWithValue("@Notes", Customer.Notes);
                //cmd.Parameters.AddWithValue("@Country", Customer.Country);
                //cmd.Parameters.AddWithValue("@City", Customer.City);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Customer  
        public void UpdateEmployee(Employee Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeId", Customer.EmployeeId);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Department", Customer.Department);
                cmd.Parameters.AddWithValue("@Salary", Customer.Salary);
                cmd.Parameters.AddWithValue("@StartDate", Customer.StartDate);
                cmd.Parameters.AddWithValue("@Notes", Customer.Notes);
                //cmd.Parameters.AddWithValue("@Country", Customer.Country);
                // cmd.Parameters.AddWithValue("@City", Customer.City);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Customer  
        public Employee GetEmployeeData(int? id)
        {
            Employee Customer = new Employee();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("usp_GetCustomerByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeId", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer.EmployeeId = Convert.ToInt32(rdr["EmployeeID"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    Customer.Department = rdr["Department"].ToString();
                    Customer.Notes = rdr["Notes"].ToString();
                    //Customer.Country = rdr["Country"].ToString();
                    //Customer.City = rdr["City"].ToString();
                }
            }
            return Customer;
        }
        //To Delete the record on a particular Customer  
        public void DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_DeleteEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
