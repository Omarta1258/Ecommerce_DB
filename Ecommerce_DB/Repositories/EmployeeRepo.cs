using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class EmployeeRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Reads all employees from the database  
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM employee ORDER BY EmployeeID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                    Employee employee = new Employee();
                                    employee.EmployeeID = reader.GetInt32(0);
                                    employee.Fname = reader.GetString(1);
                                    employee.Lname = reader.GetString(2);
                                    employee.Minit = reader.GetString(3);
                                    employee.Age = reader.GetInt32(4);
                                    employee.Gender = reader.GetString(5);
                                    employee.Position = reader.GetString(6);
                                    employee.Website = reader.GetString(7);
                                    employees.Add(employee);
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return employees;
        }

        // Reads an employee by ID from the database  
        public Employee? GetEmployeeById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employee employee = new Employee();
                                employee.EmployeeID = reader.GetInt32(0);
                                employee.Fname = reader.GetString(1);
                                employee.Lname = reader.GetString(2);
                                employee.Minit = reader.GetString(3);
                                employee.Age = reader.GetInt32(4);
                                employee.Gender = reader.GetString(5);
                                employee.Position = reader.GetString(6);
                                employee.Website = reader.GetString(7);
                                return employee;
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return null;
        }

        // Adds an employee to the database  
        public void AddEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO employee " +
                        "(Fname, Lname, Minit, Age, Gender, Position, Website) VALUES " +
                        "(@Fname, @Lname, @Minit, @Age, @Gender, @Position, @Website);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Fname", employee.Fname);
                        command.Parameters.AddWithValue("@Lname", employee.Lname);
                        command.Parameters.AddWithValue("@Minit", employee.Minit);
                        command.Parameters.AddWithValue("@Age", employee.Age);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@Position", employee.Position);
                        command.Parameters.AddWithValue("@Website", employee.Website);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        // Updates an employee in the database  
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE employee SET Fname = @Fname, Lname = @Lname, Minit = @Minit, Age = @Age, Gender = @Gender, Position = @Position, Website = @Website WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                        command.Parameters.AddWithValue("@Fname", employee.Fname);
                        command.Parameters.AddWithValue("@Lname", employee.Lname);
                        command.Parameters.AddWithValue("@Minit", employee.Minit);
                        command.Parameters.AddWithValue("@Age", employee.Age);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@Position", employee.Position);
                        command.Parameters.AddWithValue("@Website", employee.Website);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Deletes an employee from the database  
        public void DeleteEmployee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public void AssignEmployeeToShipment(int employeeId, int trackingId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "EXEC AssignEmployeeToShipment @EmployeeID, @TrackingID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@TrackingID", trackingId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public List<(int EmployeeID, int TrackingID)> GetEmployeeAssignments()
        {
            // Create a list to hold the employee assignments  
            var assignments = new List<(int EmployeeID, int TrackingID)>();

            try
            {
                // Assuming a database connection is available  
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch employee assignments from the e_works_in_s table  
                    string query = "SELECT EmployeeID, TrackingID FROM e_works_in_s";

                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int employeeID = reader.GetInt32(0);
                                int trackingID = reader.GetInt32(1);

                                assignments.Add((employeeID, trackingID));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)  
                throw new Exception("Error fetching employee assignments: " + ex.Message);
            }

            return assignments;
        }

    }
}
