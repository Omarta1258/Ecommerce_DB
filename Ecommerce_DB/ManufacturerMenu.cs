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
    public partial class ManufacturerMenu : Form
    {
        public ManufacturerMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadManufacturers();
        }

        private void ReadManufacturers()
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ManufacturerID");
            dataTable.Columns.Add("Industry");

            var repo = new ManufacturerRepo();
            var manufacturers = repo.GetManufacturers();

            foreach (var manufacturer in manufacturers)
            {
                var row = dataTable.NewRow();

                row["ManufacturerID"] = manufacturer.ManufacturerID;
                row["Industry"] = manufacturer.Industry;
                dataTable.Rows.Add(row);
            }

            this.manufacturerTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddManufacturer addManufacturer = new AddManufacturer();

            if (addManufacturer.ShowDialog() == DialogResult.OK)
            {
                ReadManufacturers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.manufacturerTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int manufacturerID = int.Parse(val);


            var repo = new ManufacturerRepo();
            var manufacturer = repo.GetManufacturerById(manufacturerID);

            if (manufacturer == null) return;

            AddManufacturer form = new AddManufacturer();

            form.EditManufacturer(manufacturer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadManufacturers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.manufacturerTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int manufacturerId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this manufacturer?",
                                "Delete Manufacturer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new ManufacturerRepo();
            repo.DeleteManufacturer(manufacturerId);
            ReadManufacturers();
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

        private void ManufacturerMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void manufacturerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
