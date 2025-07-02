using LAKERS_SUCK.Repositories;
using System.Data;
namespace LAKERS_SUCK
{
    public partial class EmployeeChoice : Form
    {
        public EmployeeChoice()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadEmployees();
        }

        private void ReadEmployees()
        {
            // Read employees and display them in the DataGridView  

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("EmployeeID");
            dataTable.Columns.Add("Fname");
            dataTable.Columns.Add("Lname");
            dataTable.Columns.Add("Minit");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("Website");

            var repo = new EmployeeRepo();
            var employees = repo.GetEmployees();

            foreach (var employee in employees)
            {
                var row = dataTable.NewRow();

                row["EmployeeID"] = employee.EmployeeID;
                row["Fname"] = employee.Fname;
                row["Lname"] = employee.Lname;
                row["Minit"] = employee.Minit;
                row["Age"] = employee.Age;
                row["Gender"] = employee.Gender;
                row["Position"] = employee.Position;
                row["Website"] = employee.Website;
                dataTable.Rows.Add(row);
            }

            this.employeeTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadEmployees();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.employeeTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }
            int employeeId = int.Parse(val);
            var repo = new EmployeeRepo();
            var employee = repo.GetEmployeeById(employeeId);
            if (employee == null)
            {
                MessageBox.Show("Employee not found.");
                return;
            }
            AddEmployee form = new AddEmployee();
            form.EditEmployee(employee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadEmployees();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.employeeTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            int employeeId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this employee?",
                                "Delete Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new EmployeeRepo();
            repo.DeleteEmployee(employeeId);
            ReadEmployees();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EtailerMenu etailerMenu = new EtailerMenu();
            etailerMenu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductsMenu productsMenu = new ProductsMenu();
            productsMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManufacturerMenu manufacturerMenu = new ManufacturerMenu();
            manufacturerMenu.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeesTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
