using LAKERS_SUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LAKERS_SUCK.Repositories
{
    public class PaymentRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //reads payments from the database
        public List<Payment> GetPayments()
        {
            var payments = new List<Payment>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM payment ORDER BY PaymentID DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Payment payment = new Payment();

                                payment.PaymentID = reader.GetInt32(0);
                                payment.OrderID = reader.GetInt32(1);
                                payment.Amount = reader.GetDecimal(2);
                                payment.Method = reader.GetString(3);

                                payments.Add(payment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return payments;
        }

        //reads payment by id from the database
        public Payment? GetPaymentById(int id)
        {
            Payment? payment = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM payment WHERE PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                payment = new Payment();
                                payment.PaymentID = reader.GetInt32(0);
                                payment.OrderID = reader.GetInt32(1);
                                payment.Amount = reader.GetDecimal(2);
                                payment.Method = reader.GetString(3);
                            }
                            return payment;
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

        //adds a payment to the database
        public void AddPayment(Payment payment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO payment (OrderID, Amount, Method) VALUES (@OrderID, @Amount, @Method)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", payment.OrderID);
                        command.Parameters.AddWithValue("@Amount", payment.Amount);
                        command.Parameters.AddWithValue("@Method", payment.Method);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //updates a payment in the database
        public void UpdatePayment(Payment payment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE payment SET OrderID = @OrderID, Amount = @Amount, Method = @Method WHERE PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
                        command.Parameters.AddWithValue("@OrderID", payment.OrderID);
                        command.Parameters.AddWithValue("@Amount", payment.Amount);
                        command.Parameters.AddWithValue("@Method", payment.Method);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //deletes a payment from the database   
        public void DeletePayment(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM payment WHERE PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", id);
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
