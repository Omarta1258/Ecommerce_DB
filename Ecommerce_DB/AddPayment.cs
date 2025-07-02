using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories;

namespace LAKERS_SUCK
{
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int paymentID = 0;

        public void EditPayment(Payment payment)
        {
            this.Text = "Edit Payment";
            this.label1.Text = "Edit Payment";

            this.lbID.Text = "" + payment.PaymentID;
            this.textBox1.Text = "" + payment.OrderID;
            this.textBox2.Text = "" + payment.Amount;
            this.textBox3.Text = payment.Method;

            this.paymentID = payment.PaymentID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.PaymentID = 0;
            payment.OrderID = int.Parse(this.textBox1.Text);
            payment.Amount = decimal.Parse(this.textBox2.Text);
            payment.Method = this.textBox3.Text;
            var repo = new PaymentRepo();
            if (payment.PaymentID == 0)
            {
                
                repo.AddPayment(payment);
            }
            else
            {
                repo.UpdatePayment(payment);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
