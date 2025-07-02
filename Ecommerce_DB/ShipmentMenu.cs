using LAKERS_SUCK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAKERS_SUCK.Repositories;

namespace LAKERS_SUCK
{
    public partial class ShipmentMenu : Form
    {
        public ShipmentMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadShipments();
            employeesAssigned();
        }

        private void ReadShipments()
        {
            // Create a DataTable to hold shipment data
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("TrackingID");
            dataTable.Columns.Add("CustomerID");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Website");
            dataTable.Columns.Add("AddressID");

            // Assuming there's a ShipmentRepository to fetch shipment data
            var repo = new ShipmentRepository();
            var shipments = repo.GetShipments();

            foreach (var shipment in shipments)
            {
                var row = dataTable.NewRow();

                row["TrackingID"] = shipment.TrackingID;
                row["CustomerID"] = shipment.CustomerID;
                row["Status"] = shipment.Status;
                row["Website"] = shipment.Website;
                row["AddressID"] = shipment.AddressID;

                dataTable.Rows.Add(row);
            }


            this.shipmentTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddShipment addShipment = new AddShipment();
            if (addShipment.ShowDialog() == DialogResult.OK)
            {
                ReadShipments();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = shipmentTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a shipment to edit.");
                return;
            }
            int trackingID = int.Parse(val);
            var repo = new ShipmentRepository();
            var shipment = repo.GetShipmentById(trackingID);
            if (shipment == null)
            {
                MessageBox.Show("Shipment not found.");
                return;
            }
            AddShipment addShipment = new AddShipment();
            addShipment.EditShipment(shipment);
            if (addShipment.ShowDialog() == DialogResult.OK)
            {
                ReadShipments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = shipmentTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a shipment to delete.");
                return;
            }
            int trackingID = int.Parse(val);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this shipment?", "Delete Shipment", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            var repo = new ShipmentRepository();
            repo.DeleteShipment(trackingID);
            ReadShipments();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            OrdersMenu ordersMenu = new OrdersMenu();
            this.Close();
            ordersMenu.Show();
        }

        private void assnEmp_Click(object sender, EventArgs e)
        {
            // Step 1: Get the selected shipment's TrackingID
            if (shipmentTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shipment to assign an employee.");
                return;
            }

            var val = shipmentTable.SelectedRows[0].Cells["TrackingID"].Value?.ToString();
            if (string.IsNullOrEmpty(val))
            {
                MessageBox.Show("Invalid shipment selected.");
                return;
            }

            int trackingID = int.Parse(val);

            // Step 2: Prompt for EmployeeID (this can be replaced with a dropdown or dialog)
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the EmployeeID to assign to this shipment:",
                "Assign Employee",
                ""
            );

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int employeeID))
            {
                MessageBox.Show("Invalid EmployeeID entered.");
                return;
            }

            // Step 3: Call the repository method
            try
            {
                var employeeRepo = new EmployeeRepo();
                employeeRepo.AssignEmployeeToShipment(employeeID, trackingID);

                // Step 4: Notify the user
                MessageBox.Show("Employee successfully assigned to the shipment.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning employee: " + ex.Message);
            }
        }

        private void employeesAssigned()
        {

            // Step 1: Create a DataTable to hold the data from the e_works_in_s table  
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("EmployeeID");
            dataTable1.Columns.Add("TrackingID");

            try
            {
                // Step 2: Fetch data from the e_works_in_s table using the EmployeeRepo  
                var repo = new EmployeeRepo();

                // Corrected method call to fetch assigned employees  
                var assignedEmployees = repo.GetEmployeeAssignments(); // Ensure this method returns a collection with EmployeeID and TrackingID  

                // Ensure assignedEmployees is a collection that can be iterated  
                foreach (var assignment in assignedEmployees)
                {
                    var row = dataTable1.NewRow();
                    row["EmployeeID"] = assignment.EmployeeID;
                    row["TrackingID"] = assignment.TrackingID; // Ensure the object returned by GetEmployeeAssignments has a TrackingID property  
                    dataTable1.Rows.Add(row);
                }

                // Step 4: Bind the DataTable to the ewsTable DataGridView  
                this.ewsTable.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned employees: " + ex.Message);
            }
        }

        private void ewsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShipmentMenu_Load(object sender, EventArgs e)
        {

        }

        private void EmployeesAssigned(object sender, EventArgs e)
        {
            // Step 1: Create a DataTable to hold the data from the e_works_in_s table  
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("EmployeeID");
            dataTable1.Columns.Add("TrackingID");

            try
            {
                // Step 2: Fetch data from the e_works_in_s table using the EmployeeRepo  
                var repo = new EmployeeRepo();

                // Corrected method call to fetch assigned employees  
                var assignedEmployees = repo.GetEmployeeAssignments(); // Ensure this method returns a collection with EmployeeID and TrackingID  

                // Ensure assignedEmployees is a collection that can be iterated  
                foreach (var assignment in assignedEmployees)
                {
                    var row = dataTable1.NewRow();
                    row["EmployeeID"] = assignment.EmployeeID;
                    row["TrackingID"] = assignment.TrackingID; // Ensure the object returned by GetEmployeeAssignments has a TrackingID property  
                    dataTable1.Rows.Add(row);
                }

                // Step 4: Bind the DataTable to the ewsTable DataGridView  
                this.ewsTable.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned employees: " + ex.Message);
            }
        }
    }

}
