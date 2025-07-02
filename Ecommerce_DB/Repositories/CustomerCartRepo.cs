using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class CustomerCartRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //reads customer carts from the database  
        public List<CustomerCart> GetCustomerCarts()
        {
            var customerCarts = new List<CustomerCart>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM customerCart ORDER BY CustomerID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CustomerCart customerCart = new CustomerCart();

                                customerCart.CustomerID = reader.GetInt32(0);
                                customerCart.Email = reader.GetString(1);
                                customerCart.Fname = reader.GetString(2);
                                customerCart.Lname = reader.GetString(3);
                                customerCart.Minit = reader.GetString(4);
                                customerCart.Age = reader.GetInt32(5);
                                customerCart.Gender = reader.GetString(6);
                                customerCart.Subtotal = reader.GetDecimal(7);

                                customerCarts.Add(customerCart);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return customerCarts;
        }

        //reads customer cart by id from the database  
        public CustomerCart? GetShipmentById(int id)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM customerCart WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerCart customerCart = new CustomerCart();
                                customerCart.CustomerID = reader.GetInt32(0);
                                customerCart.Email = reader.GetString(1);
                                customerCart.Fname = reader.GetString(2);
                                customerCart.Lname = reader.GetString(3);
                                customerCart.Minit = reader.GetString(4);
                                customerCart.Age = reader.GetInt32(5);
                                customerCart.Gender = reader.GetString(6);
                                customerCart.Subtotal = reader.GetDecimal(7);
                                return customerCart;
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

        public CustomerCart? GetCustomerByEmail(string email)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM customerCart WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerCart customerCart = new CustomerCart();
                                customerCart.CustomerID = reader.GetInt32(0);
                                customerCart.Email = reader.GetString(1);
                                customerCart.Fname = reader.GetString(2);
                                customerCart.Lname = reader.GetString(3);
                                customerCart.Minit = reader.GetString(4);
                                customerCart.Age = reader.GetInt32(5);
                                customerCart.Gender = reader.GetString(6);
                                customerCart.Subtotal = reader.GetDecimal(7);
                                return customerCart;
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

        //adds a customer cart to the database  
        public void AddCustomerCart(CustomerCart customerCart)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO customerCart (Email, Fname, Lname, Minit, Age, Gender, Subtotal) VALUES (@Email, @Fname, @Lname, @Minit, @Age, @Gender, @Subtotal)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", customerCart.Email);
                        command.Parameters.AddWithValue("@Fname", customerCart.Fname);
                        command.Parameters.AddWithValue("@Lname", customerCart.Lname);
                        command.Parameters.AddWithValue("@Minit", customerCart.Minit);
                        command.Parameters.AddWithValue("@Age", customerCart.Age);
                        command.Parameters.AddWithValue("@Gender", customerCart.Gender);
                        command.Parameters.AddWithValue("@Subtotal", customerCart.Subtotal);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //updates a customer cart in the database  
        public void UpdateCustomerCart(CustomerCart customerCart)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE customerCart SET Email = @Email, Fname = @Fname, Lname = @Lname, Minit = @Minit, Age = @Age, Gender = @Gender, Subtotal = @Subtotal WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerCart.CustomerID);
                        command.Parameters.AddWithValue("@Email", customerCart.Email);
                        command.Parameters.AddWithValue("@Fname", customerCart.Fname);
                        command.Parameters.AddWithValue("@Lname", customerCart.Lname);
                        command.Parameters.AddWithValue("@Minit", customerCart.Minit);
                        command.Parameters.AddWithValue("@Age", customerCart.Age);
                        command.Parameters.AddWithValue("@Gender", customerCart.Gender);
                        command.Parameters.AddWithValue("@Subtotal", customerCart.Subtotal);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //deletes a customer cart from the database  
        public void DeleteCustomerCart(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM customerCart WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //stored procedure 
        public List<CustomerCart> GetTopCustomersBySubtotal(int topN)
        {
            var customerCarts = new List<CustomerCart>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "GetTopCustomersBySubtotal"; // Stored procedure name

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TopN", topN);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CustomerCart customerCart = new CustomerCart
                                {
                                    CustomerID = reader.GetInt32(0),
                                    Email = reader.GetString(1),
                                    Fname = reader.GetString(2),
                                    Lname = reader.GetString(3),
                                    Minit = reader.GetString(4),
                                    Age = reader.GetInt32(5),
                                    Gender = reader.GetString(6),
                                    Subtotal = reader.GetDecimal(7)
                                };

                                customerCarts.Add(customerCart);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return customerCarts;
        }
    }
}
