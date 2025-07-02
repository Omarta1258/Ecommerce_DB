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
    public partial class PaymentMenu : Form
    {
        public PaymentMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadPayments();
        }

        private void ReadPayments()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("PaymentID");
            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Method");


            var repo = new PaymentRepo();
            var payments = repo.GetPayments();

            foreach (var payment in payments)
            {
                var row = dataTable.NewRow();

                row["PaymentID"] = payment.PaymentID;
                row["OrderID"] = payment.OrderID;
                row["Amount"] = payment.Amount;
                row["Method"] = payment.Method;

                dataTable.Rows.Add(row);
            }

            this.paymentTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
            if (addPayment.ShowDialog() == DialogResult.OK)
            {
                ReadPayments();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.paymentTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int paymentId = int.Parse(val);
            var repo = new PaymentRepo();
            var payment = repo.GetPaymentById(paymentId);
            if (payment == null)
            {
                MessageBox.Show("Payment not found.");
                return;
            }
            AddPayment form = new AddPayment();
            form.EditPayment(payment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadPayments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.paymentTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int paymentId = int.Parse(val);
            DialogResult dialogResult =
               MessageBox.Show("Are you sure you want to delete this client?",
                               "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new PaymentRepo();
            repo.DeletePayment(paymentId);
            ReadPayments();
        }

        private void PaymentMenu_Load(object sender, EventArgs e)
        {

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

        private void backbtn_Click(object sender, EventArgs e)
        {
            EmployeeChoice form = new EmployeeChoice();
            this.Close();
            form.Show();
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
