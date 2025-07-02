using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class OrdersRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public List<Orders> GetOrders()
        {
            var orders = new List<Orders>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM orders ORDER BY OrderID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Orders order = new Orders();

                                order.OrderID = reader.GetInt32(0);
                                order.CustomerID = reader.GetInt32(1);
                                order.ProductsPrice = reader.GetDecimal(2);
                                order.ShippingPrice = reader.GetDecimal(3);
                                order.Taxes = reader.GetDecimal(4);
                                order.createdAt = reader.GetDateTime(5).ToString("yyyy-MM-dd HH:mm:ss");

                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return orders;
        }

        
        public Orders? GetOrderById(int id)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM orders WHERE OrderID = @OrderID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Orders order = new Orders();
                                order = new Orders();
                                order.OrderID = reader.GetInt32(0);
                                order.CustomerID = reader.GetInt32(1);
                                order.ProductsPrice = reader.GetDecimal(2);
                                order.ShippingPrice = reader.GetDecimal(3);
                                order.Taxes = reader.GetDecimal(4);
                                order.createdAt = reader.GetDateTime(5).ToString();
                                return order;
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

        
        public void AddOrder(Orders order)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO orders (CustomerID, Products_Price, Shipping_Price, Taxes) VALUES (@CustomerID, @Products_Price, @Shipping_Price, @Taxes)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                        command.Parameters.AddWithValue("@Products_Price", order.ProductsPrice);
                        command.Parameters.AddWithValue("@Shipping_Price", order.ShippingPrice);
                        command.Parameters.AddWithValue("@Taxes", order.Taxes);
                        //command.Parameters.AddWithValue("@Date", order.Date);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        
        public void UpdateOrder(Orders order)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE orders SET CustomerID = @CustomerID, Products_Price = @Products_Price, Shipping_Price = @Shipping_Price, Taxes = @Taxes, WHERE OrderID = @OrderID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                        command.Parameters.AddWithValue("@Products_Price", order.ProductsPrice);
                        command.Parameters.AddWithValue("@Shipping_Price", order.ShippingPrice);
                        command.Parameters.AddWithValue("@Taxes", order.Taxes);
                        //command.Parameters.AddWithValue("@Date", order.createdAt);
                        command.Parameters.AddWithValue("@OrderID", order.OrderID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        
        public void DeleteOrder(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM orders WHERE OrderID = @OrderID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", id);
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
