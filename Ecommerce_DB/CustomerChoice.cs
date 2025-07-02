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
    public partial class CustomerChoice : Form
    {
        public CustomerChoice()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadProducts();
        }

        private void ReadProducts()
        {
            // Read customers from the database and display them in the DataGridView

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CustomerID");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Fname");
            dataTable.Columns.Add("Lname");
            dataTable.Columns.Add("Minit");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Subtotal");

            var repo = new CustomerCartRepo();
            var customers = repo.GetCustomerCarts();

            foreach (var customer in customers)
            {
                var row = dataTable.NewRow();

                row["CustomerID"] = customer.CustomerID;
                row["Email"] = customer.Email;
                row["Fname"] = customer.Fname;
                row["Lname"] = customer.Lname;
                row["Minit"] = customer.Minit;
                row["Age"] = customer.Age;
                row["Gender"] = customer.Gender;
                row["Subtotal"] = customer.Subtotal;

                dataTable.Rows.Add(row);
            }

            this.customerTable.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddressMenu addressMenu = new AddressMenu();
            addressMenu.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrdersMenu ordersMenu = new OrdersMenu();
            ordersMenu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaymentMenu paymentMenu = new PaymentMenu();
            paymentMenu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();

            if (addCustomer.ShowDialog() == DialogResult.OK)
            {
                ReadProducts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.customerTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }
            int customerId = int.Parse(val);

            var repo = new CustomerCartRepo();
            var customer = repo.GetShipmentById(customerId);

            if (customer == null)
            {
                MessageBox.Show("Customer not found.");
                return;
            }

            AddCustomer form = new AddCustomer();
            form.EditCustomer(customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadProducts();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.customerTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }
            int customerId = int.Parse(val);
            DialogResult dialogResult =
               MessageBox.Show("Are you sure you want to delete this client?",
                               "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new CustomerCartRepo();
            repo.DeleteCustomerCart(customerId);
            ReadProducts();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sortCustomer_Click(object sender, EventArgs e)
        {

        }

        private void sortCustomer_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the number of top customers to display:",
                "Sort Customers by Subtotal",
                "5"); // Default value is 5

            if (int.TryParse(input, out int topN) && topN > 0)
            {
                var repo = new CustomerCartRepo();
                var topCustomers = repo.GetTopCustomersBySubtotal(topN);

                if (topCustomers.Count == 0)
                {
                    MessageBox.Show("No customers found.");
                    return;
                }

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CustomerID");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Fname");
                dataTable.Columns.Add("Lname");
                dataTable.Columns.Add("Minit");
                dataTable.Columns.Add("Age");
                dataTable.Columns.Add("Gender");
                dataTable.Columns.Add("Subtotal");

                foreach (var customer in topCustomers)
                {
                    var row = dataTable.NewRow();
                    row["CustomerID"] = customer.CustomerID;
                    row["Email"] = customer.Email;
                    row["Fname"] = customer.Fname;
                    row["Lname"] = customer.Lname;
                    row["Minit"] = customer.Minit;
                    row["Age"] = customer.Age;
                    row["Gender"] = customer.Gender;
                    row["Subtotal"] = customer.Subtotal;

                    dataTable.Rows.Add(row);
                }

                this.customerTable.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.");
            }
        }

        private void CustomerChoice_Load(object sender, EventArgs e)
        {

        }
    }
}