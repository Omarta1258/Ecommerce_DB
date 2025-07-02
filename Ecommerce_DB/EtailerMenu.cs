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
    public partial class EtailerMenu : Form
    {
        public EtailerMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadEtailers();
        }

        private void ReadEtailers()
        {
            // Create a DataTable to hold e-tailer data
            DataTable dataTable = new DataTable();

            //dataTable.Columns.Add("EtailerID");
            //dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Website");
            //dataTable.Columns.Add("ContactEmail");
            dataTable.Columns.Add("Brand");

            // Assuming there's an EtailerRepo to fetch e-tailer data
            var repo = new E_TailerRepo();
            var etailers = repo.GetEtailers();

            foreach (var etailer in etailers)
            {
                var row = dataTable.NewRow();


                row["Website"] = etailer.Website;
                row["Brand"] = etailer.Brand;
                dataTable.Rows.Add(row);
            }

            // Assuming there's a DataGridView named etailerTable in the form
            this.etailerTable.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEtailer addEtailer = new AddEtailer();
            if (addEtailer.ShowDialog() == DialogResult.OK)
            {
                // Refresh the e-tailer list after adding a new one
                ReadEtailers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.etailerTable.SelectedRows.Count == 0)
            {
                return;
            }

            var website = this.etailerTable.SelectedRows[0].Cells["Website"].Value?.ToString();
            if (string.IsNullOrEmpty(website))
            {
                return;
            }

            var repo = new E_TailerRepo();
            var etailer = repo.GetEtailerByWebsite(website);

            if (etailer == null) return;


            AddEtailer form = new AddEtailer();

            form.EditEtailer(etailer);


            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadEtailers();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.etailerTable.SelectedRows.Count == 0)
            {
                return;
            }

            var website = this.etailerTable.SelectedRows[0].Cells["Website"].Value?.ToString();
            if (string.IsNullOrEmpty(website))
            {
                return;
            }

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this e-tailer?",
                                "Delete E-Tailer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new E_TailerRepo();
            repo.DeleteEtailer(website);
            ReadEtailers();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EtailerMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
