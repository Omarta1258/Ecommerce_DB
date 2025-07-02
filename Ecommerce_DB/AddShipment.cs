using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAKERS_SUCK
{
    public partial class AddShipment : Form
    {
        public AddShipment()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int trackingID = 0;
        
        public void EditShipment(Models.Shipment shipment)
        {
            this.Text = "Edit Shipment";
            this.label1.Text = "Edit Shipment";

            this.lbID1.Text = "" + shipment.TrackingID;
            this.textBox1.Text = "" + shipment.Status;
            this.textBox2.Text = "" + shipment.CustomerID;
            this.textBox3.Text = "" + shipment.Website;
            this.textBox4.Text = "" + shipment.AddressID;

            this.trackingID = shipment.TrackingID;
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            Models.Shipment shipment = new Models.Shipment();
            shipment.TrackingID = 0;

            shipment.Status = this.textBox1.Text;
            shipment.CustomerID = int.Parse(this.textBox2.Text);
            shipment.Website = this.textBox3.Text;
            shipment.AddressID = int.Parse(this.textBox4.Text);

            var repo = new Repositories.ShipmentRepository();
            if (shipment.TrackingID == 0)
            {
                repo.AddShipment(shipment);
            }
            else
            {
                repo.UpdateShipment(shipment);
            }
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
