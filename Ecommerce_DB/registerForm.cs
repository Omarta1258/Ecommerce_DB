using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories;
using System;
using System.Windows.Forms;

namespace LAKERS_SUCK
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int customerID = 0;

        // Method to edit a customer’s details
        public void EditCustomer(CustomerCart customerCart)
        {
            this.Text = "Edit Customer";
            this.label1.Text = "Edit Customer";

            this.lbID.Text = "" + customerCart.CustomerID;
            this.textBox1.Text = customerCart.Email;
            this.textBox2.Text = customerCart.Fname;
            this.textBox3.Text = customerCart.Lname;
            this.textBox4.Text = customerCart.Minit;
            this.textBox5.Text = "" + customerCart.Age;
            this.textBox6.Text = customerCart.Gender;
            this.textBox7.Text = "" + customerCart.Subtotal;

            this.customerID = customerCart.CustomerID;
        }

        // Method to save a new or edited customer
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerCart customerCart = new CustomerCart
            {
                CustomerID = this.customerID, // Assign the ID for editing, or 0 for new customer
                Email = this.textBox1.Text,
                Fname = this.textBox2.Text,
                Lname = this.textBox3.Text,
                Minit = this.textBox4.Text,
                Age = int.Parse(this.textBox5.Text),
                Gender = this.textBox6.Text,
                Subtotal = (int)decimal.Parse(this.textBox7.Text)
            };

            var repo = new CustomerCartRepo();

            // If editing, update the customer, else add as new
            if (customerCart.CustomerID == 0)
            {
                repo.AddCustomerCart(customerCart); // Add new customer
            }
            else
            {
                repo.UpdateCustomerCart(customerCart); // Update existing customer
            }

            this.DialogResult = DialogResult.OK;
            CustomerChoice customerChoiceForm = new CustomerChoice();
            customerChoiceForm.Show();
            this.Close();
        }

        // Cancel the action and close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Handle label9 click event if necessary
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label2 click event if necessary
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            // You can add any load logic here if needed
        }
    }
}
