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
    public partial class AddManufacturer : Form
    {
        public AddManufacturer()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int manufacturerID = 0;

        public void EditManufacturer(Manufacturer manufacturer)
        {
            this.Text = "Edit Manufacturer";
            this.label1.Text = "Edit Manufacturer";

            this.lbID.Text = "" + manufacturer.ManufacturerID;
            this.textBox2.Text = manufacturer.Industry;

            this.manufacturerID = manufacturer.ManufacturerID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ManufacturerID = this.manufacturerID;
            manufacturer.Industry = this.textBox2.Text;

            var repo = new ManufacturerRepo();
            if (manufacturer.ManufacturerID == 0)
            {
                repo.AddManufacturer(manufacturer);
            }
            else
            {
                
                repo.UpdateManufacturer(manufacturer);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddManufacturer_Load(object sender, EventArgs e)
        {

        }
    }
}
