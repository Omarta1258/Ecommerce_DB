using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAKERS_SUCK
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int customerID = 0;

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



        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerCart customerCart = new CustomerCart();

            customerCart.CustomerID = 0;

            customerCart.Email = this.textBox1.Text;
            customerCart.Fname = this.textBox2.Text;
            customerCart.Lname = this.textBox3.Text;
            customerCart.Minit = this.textBox4.Text;
            customerCart.Age = int.Parse(this.textBox5.Text);
            customerCart.Gender = this.textBox6.Text;
            customerCart.Subtotal = (int)decimal.Parse(this.textBox7.Text);

            var repo = new CustomerCartRepo();

            if (customerCart.CustomerID == 0)
            {
                repo.UpdateCustomerCart(customerCart);
            }
            repo.AddCustomerCart(customerCart);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
