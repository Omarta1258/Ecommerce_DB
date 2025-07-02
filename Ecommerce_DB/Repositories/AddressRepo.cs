using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class AddressRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Reads all addresses from the database  
        public List<Address> GetAddresses()
        {
            var addresses = new List<Address>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM address ORDER BY AddressID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Address address = new Address
                                {
                                    AddressID = reader.GetInt32(0),
                                    Country = reader.GetString(1),
                                    City = reader.GetString(2),
                                    CustomerID = reader.GetInt32(3)
                                };
                                addresses.Add(address);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return addresses;
        }

        // Reads an address by ID from the database  
        public Address? GetAddressById(int id)
        {
            Address address = new Address();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM address WHERE AddressID = @AddressID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AddressID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                address.AddressID = reader.GetInt32(0);
                                address.Country = reader.GetString(1);
                                address.City = reader.GetString(2);
                                address.CustomerID = reader.GetInt32(3);
                            }
                            return address;
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

        // Adds an address to the database  
        public void AddAddress(Address address)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO address (Country, City, CustomerID) VALUES (@Country, @City, @CustomerID);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Country", address.Country);
                        command.Parameters.AddWithValue("@City", address.City);
                        command.Parameters.AddWithValue("@CustomerID", address.CustomerID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Updates an address in the database  
        public void UpdateAddress(Address address)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE address SET Country = @Country, City = @City, CustomerID = @CustomerID WHERE AddressID = @AddressID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AddressID", address.AddressID);
                        command.Parameters.AddWithValue("@Country", address.Country);
                        command.Parameters.AddWithValue("@City", address.City);
                        command.Parameters.AddWithValue("@CustomerID", address.CustomerID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Deletes an address from the database  
        public void DeleteAddress(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM address WHERE AddressID = @AddressID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AddressID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
