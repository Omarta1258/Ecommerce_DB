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
    public partial class AddAddress : Form
    {
        public AddAddress()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }
        private int addressID = 0;

        public void EditAddress(Address address)
        {
            this.Text = "Edit Address";
            this.label1.Text = "Edit Address";

            this.lbID.Text = "" + address.AddressID;
            this.textBox2.Text = address.Country;
            this.textBox3.Text = address.City;
            this.textBox4.Text = "" + address.CustomerID;

            this.addressID = address.AddressID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.AddressID = 0;


            address.Country = this.textBox2.Text;
            address.City = this.textBox3.Text;
            address.CustomerID = int.Parse(this.textBox4.Text);

            var repo = new AddressRepo();

            if (address.AddressID == 0)
            {
                repo.AddAddress(address);
            }
            else
            {
                repo.UpdateAddress(address);
            }



            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.Cancel;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
