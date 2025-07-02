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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private int employeeId = 0;
        public void EditEmployee(Employee employee)
        {
            this.Text = "Edit Employee";
            this.label1.Text = "Edit Employee";

            this.lbID.Text = "" + employee.EmployeeID;
            this.textBox1.Text = employee.Fname;
            this.textBox2.Text = employee.Lname;
            this.textBox3.Text = employee.Minit;
            this.textBox4.Text = "" + employee.Age;
            this.textBox5.Text = employee.Gender;
            this.textBox6.Text = employee.Position;
            this.textBox7.Text = employee.Website;

            this.employeeId = employee.EmployeeID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = 0;
            employee.Fname = this.textBox1.Text;
            employee.Lname = this.textBox2.Text;
            employee.Minit = this.textBox3.Text;
            employee.Age = int.Parse(this.textBox4.Text);
            employee.Gender = this.textBox5.Text;
            employee.Position = this.textBox6.Text;
            employee.Website = this.textBox7.Text;


            var repo = new EmployeeRepo();

            if (employee.EmployeeID == 0)
            {
                repo.UpdateEmployee(employee);
            }
            repo.AddEmployee(employee);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
