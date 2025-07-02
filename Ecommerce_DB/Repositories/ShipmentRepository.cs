using LAKERS_SUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class ShipmentRepository
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //reads shipments from the database
        public List<Shipment> GetShipments()
        {
            var shipments = new List<Shipment>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM shipment ORDER BY TrackingID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Shipment shipment = new Shipment();

                                shipment.TrackingID = reader.GetInt32(0);
                                shipment.Status = reader.GetString(1);
                                shipment.CustomerID = reader.GetInt32(2);
                                shipment.Website = reader.GetString(3);
                                shipment.AddressID = reader.GetInt32(4);

                                shipments.Add(shipment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return shipments;
        }

        //reads shipment by id from the database
        public Shipment? GetShipmentById(int id)
        {
            Shipment? shipment = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM shipment WHERE TrackingID = @TrackingID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TrackingID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                shipment = new Shipment();
                                shipment.TrackingID = reader.GetInt32(0);
                                shipment.Status = reader.GetString(1);
                                shipment.CustomerID = reader.GetInt32(2);
                                shipment.Website = reader.GetString(3);
                                shipment.AddressID = reader.GetInt32(4);
                            }
                            return shipment;
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

        //adds a shipment to the database
        public void AddShipment(Shipment shipment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO shipment (Status, CustomerID, Website, AddressID) VALUES (@Status, @CustomerID, @Website, @AddressID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Status", shipment.Status);
                        command.Parameters.AddWithValue("@CustomerID", shipment.CustomerID);
                        command.Parameters.AddWithValue("@Website", shipment.Website);
                        command.Parameters.AddWithValue("@AddressID", shipment.AddressID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //updates a shipment in the database
        public void UpdateShipment(Shipment shipment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE shipment SET Status = @Status, CustomerID = @CustomerID, Website = @Website, AddressID = @AddressID WHERE TrackingID = @TrackingID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Status", shipment.Status);
                        command.Parameters.AddWithValue("@CustomerID", shipment.CustomerID);
                        command.Parameters.AddWithValue("@Website", shipment.Website);
                        command.Parameters.AddWithValue("@AddressID", shipment.AddressID);
                        command.Parameters.AddWithValue("@TrackingID", shipment.TrackingID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //deletes a shipment from the database
        public void DeleteShipment(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM shipment WHERE TrackingID = @TrackingID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TrackingID", id);
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
