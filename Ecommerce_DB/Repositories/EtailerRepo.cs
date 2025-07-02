using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class E_TailerRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Reads all e-tailers from the database  
        public List<Etailer> GetEtailers()
        {
            var etailers = new List<Etailer>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM etailer ORDER BY Brand ASC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Etailer etailer = new Etailer
                                {
                                    Website = reader.GetString(0),
                                    Brand = reader.GetString(1)
                                };
                                etailers.Add(etailer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return etailers;
        }

        // Reads an e-tailer by website from the database  
        public Etailer? GetEtailerByWebsite(string website)
        {
            Etailer etailer = new Etailer();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM etailer WHERE Website = @Website";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Website", website);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                etailer.Website = reader.GetString(0);
                                etailer.Brand = reader.GetString(1);
                            }
                            return etailer;
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

        // Adds a new e-tailer to the database  
        public void AddEtailer(Etailer etailer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO etailer (Website, Brand) VALUES (@Website, @Brand)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Website", etailer.Website);
                        command.Parameters.AddWithValue("@Brand", etailer.Brand);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Updates an existing e-tailer in the database  
        public void UpdateEtailer(Etailer etailer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE etailer SET Website = @Website WHERE Brand = @Brand";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Website", etailer.Website);
                        command.Parameters.AddWithValue("@Brand", etailer.Brand);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Deletes an e-tailer from the database  
        public void DeleteEtailer(string website)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM etailer WHERE Website = @Website";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Website", website);
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
