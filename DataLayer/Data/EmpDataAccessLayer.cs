using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Data
{
    public class EmpDataAccessLayer : IEmpDataAccessLayer
    {
        private readonly IConfiguration _config;
        public string ConnectionStringName { get; set; } = "EmpWage";
        public EmpDataAccessLayer(IConfiguration config)
        {
            _config = config;
        }


        public IEnumerable<Employee> GetAllEmployee()
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
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
            string connectionString = _config.GetConnectionString(ConnectionStringName);
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
            string connectionString = _config.GetConnectionString(ConnectionStringName);
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
            string connectionString = _config.GetConnectionString(ConnectionStringName);
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
            string connectionString = _config.GetConnectionString(ConnectionStringName);
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

