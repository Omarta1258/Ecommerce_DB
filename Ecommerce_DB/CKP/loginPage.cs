using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories;

namespace LAKERS_SUCK
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //LoadProducts();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            // Create an instance of the CustomerChoice form
            CustomerChoice customerChoiceForm = new CustomerChoice();

            // Show the CustomerChoice form
            customerChoiceForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeChoice employeeChoiceForm = new EmployeeChoice();
            employeeChoiceForm.Show();
            this.Hide();
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(50, 120, 200); 
        }
    }
}
//might have to change the functions accordingly