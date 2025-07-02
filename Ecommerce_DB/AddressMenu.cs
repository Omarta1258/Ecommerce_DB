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
    public partial class AddressMenu : Form
    {
        public AddressMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadAddresses();
        }

        private void ReadAddresses()
        {
            // Create a DataTable to hold address data
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("AddressID");
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("City");
            dataTable.Columns.Add("CustomerID");

            var repo = new AddressRepo();
            var addresses = repo.GetAddresses();

            foreach (var address in addresses)
            {
                var row = dataTable.NewRow();

                row["AddressID"] = address.AddressID;

                row["Country"] = address.Country;
                row["City"] = address.City;
                row["CustomerID"] = address.CustomerID;
                dataTable.Rows.Add(row);
            }

            this.addressTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAddress addAddress = new AddAddress();
            if (addAddress.ShowDialog() == DialogResult.OK)
            {
                ReadAddresses();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.addressTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select an address to edit.");
                return;
            }
            int addressID = int.Parse(val);

            var repo = new AddressRepo();
            var address = repo.GetAddressById(addressID);

            if (address == null)
            {
                MessageBox.Show("Address not found.");
                return;
            }
            AddAddress form = new AddAddress();
            form.EditAddress(address);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadAddresses();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.addressTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select an address to edit.");
                return;
            }
            int addressID = int.Parse(val);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this address?", "Delete Address", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var repo = new AddressRepo();
            repo.DeleteAddress(addressID);
            ReadAddresses();
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

        private void AddressMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
