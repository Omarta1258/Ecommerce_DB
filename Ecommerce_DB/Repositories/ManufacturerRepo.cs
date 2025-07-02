using LAKERS_SUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class ManufacturerRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //reads manufacturers from the database
        public List<Manufacturer> GetManufacturers()
        {
            var manufacturers = new List<Manufacturer>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM manufacturer ORDER BY ManufacturerID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Manufacturer manufacturer = new Manufacturer();

                                manufacturer.ManufacturerID = reader.GetInt32(0);
                                manufacturer.Industry = reader.GetString(1);

                                manufacturers.Add(manufacturer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return manufacturers;
        }

        //reads manufacturer by id from the database
        public Manufacturer? GetManufacturerById(int id)
        {
            Manufacturer manufacturer = new Manufacturer();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM manufacturer WHERE ManufacturerID = @ManufacturerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ManufacturerID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                

                                manufacturer.ManufacturerID = reader.GetInt32(0);
                                manufacturer.Industry = reader.GetString(1);
                                
                            }
                            return manufacturer;
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

        //adds a manufacturer to the database
        public void AddManufacturer(Manufacturer manufacturer)  
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO manufacturer (Industry) VALUES (@Industry)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Industry", manufacturer.Industry);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //updates a manufacturer in the database
        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE manufacturer SET Industry = @Industry WHERE ManufacturerID = @ManufacturerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //command.Parameters.AddWithValue("@ManufacturerID", manufacturer.ManufacturerID);
                        command.Parameters.AddWithValue("@Industry", manufacturer.Industry);
                        command.Parameters.AddWithValue("@ManufacturerID", manufacturer.ManufacturerID);    
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //deletes a manufacturer from the database
        public void DeleteManufacturer(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM manufacturer WHERE ManufacturerID = @ManufacturerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ManufacturerID", id);
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
