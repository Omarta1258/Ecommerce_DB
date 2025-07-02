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
using LAKERS_SUCK.Models;

namespace LAKERS_SUCK
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int orderID = 0;
    
        public void EditOrder(Orders order)
        {
            this.Text = "Edit Order";
            this.label1.Text = "Edit Order";

            this.lbID.Text = "" + order.OrderID;
            this.textBox1.Text = "" + order.CustomerID;
            this.textBox2.Text = "" + order.ProductsPrice;
            this.textBox3.Text = "" + order.ShippingPrice;
            this.textBox4.Text = "" + order.Taxes;

            this.orderID = order.OrderID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.OrderID = 0;

            order.CustomerID = int.Parse(this.textBox1.Text);
            order.ProductsPrice = decimal.Parse(this.textBox2.Text);
            order.ShippingPrice = decimal.Parse(this.textBox3.Text);
            order.Taxes = decimal.Parse(this.textBox4.Text);

            var repo = new OrdersRepo();
            if (order.OrderID == 0)
            {
                repo.AddOrder(order);
            }
            else
            {
                repo.UpdateOrder(order);

            }


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        
    }
}
