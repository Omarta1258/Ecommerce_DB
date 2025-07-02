using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace LAKERS_SUCK
{
    public partial class loginForm : Form
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string email = string.Empty;
        public loginForm(string email)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            this.email = email;
            textBoxEmail.Text = email;
        }

        // Method to validate login
        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.textBoxEmail.Text = this.email;
            string password = this.textBoxPassword.Text;

            // Validate inputs (optional)
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new CustomerCartRepo();
            var customer = repo.GetCustomerByEmail(email);

            if (customer == null)
            {
                MessageBox.Show("Email not found. Please check your credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (customer.Password != password)  // Assuming there is a Password field in CustomerCart
            //{
            //    MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            adminMenu adminMenu = new adminMenu(customer.CustomerID);
            adminMenu.Show();
            this.Close();
        }

        // Method to handle cancel action
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // Set the email in the textbox when the form loads
            this.textBoxEmail.Text = this.email;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

