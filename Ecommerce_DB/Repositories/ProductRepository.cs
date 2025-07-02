using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAKERS_SUCK.Models;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class ProductRepository
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //reads products from the database
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    connection.Open();
                    string sql = "SELECT * FROM product ORDER BY ProductID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                Manufacturer manufacturer = new Manufacturer();

                                product.ProductID = reader.GetInt32(0);
                                product.Name = reader.GetString(1);
                                product.Price = reader.GetDecimal(2);
                                product.Description = reader.GetString(3);
                                product.CategoryName = reader.GetString(4);
                                product.ManufacturerID = reader.GetInt32(5);



                                products.Add(product);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return products;
        }

        //reads client by id from the database
        public Product? GetProductById(int id)
        {
            Product product = new Product();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM product WHERE ProductID = @ProductID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                product.ProductID = reader.GetInt32(0);
                                product.Name = reader.GetString(1);
                                product.Price = reader.GetDecimal(2);
                                product.Description = reader.GetString(3);
                                product.CategoryName = reader.GetString(4);
                                product.ManufacturerID = reader.GetInt32(5);
                            }
                            return product;
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

        //adds a product to the database
        public void AddProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO product (Name, Price, Description, Category_Name, ManufacturerID) VALUES (@Name, @Price, @Description, @Category_Name, @ManufacturerID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Category_Name", product.CategoryName);
                        command.Parameters.AddWithValue("@ManufacturerID", product.ManufacturerID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //updates a product in the database
        public void UpdateProduct(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE product SET Name = @Name, Price = @Price, Description = @Description, CategoryName = @CategoryName, ManufacturerID = @ManufacturerID WHERE ProductID = @ProductID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", product.ProductID);
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@CategoryName", product.CategoryName);
                        command.Parameters.AddWithValue("@ManufacturerID", product.ManufacturerID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //deletes a product from the database
        public void DeleteProduct(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM product WHERE ProductID = @ProductID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", id);
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
