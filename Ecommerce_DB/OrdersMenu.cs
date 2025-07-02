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
    public partial class OrdersMenu : Form
    {
        public OrdersMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ReadOrders();
        }

        private void ReadOrders()
        {
            // Create a DataTable to hold order data
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("CustomerID");
            dataTable.Columns.Add("ProductsPrice");
            dataTable.Columns.Add("ShippingPrice");
            dataTable.Columns.Add("Taxes");
            dataTable.Columns.Add("OrderDate");

            // Assuming there's an OrderRepository to fetch order data
            var repo = new OrdersRepo();
            var orders = repo.GetOrders();

            foreach (var order in orders)
            {
                var row = dataTable.NewRow();

                row["OrderID"] = order.OrderID;
                row["CustomerID"] = order.CustomerID;
                row["ProductsPrice"] = order.ProductsPrice;
                row["ShippingPrice"] = order.ShippingPrice;
                row["Taxes"] = order.Taxes;
                row["OrderDate"] = order.createdAt;

                dataTable.Rows.Add(row);
            }

            // Assuming there's a DataGridView named ordersTable in the form
            this.orderTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            if (addOrder.ShowDialog() == DialogResult.OK)
            {
                ReadOrders();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.orderTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int orderId = int.Parse(val);

            var repo = new OrdersRepo();
            var order = repo.GetOrderById(orderId);

            if (order == null)
            {
                MessageBox.Show("Order not found.");
                return;
            }
            AddOrder form = new AddOrder();
            form.EditOrder(order);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadOrders();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.orderTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                return;
            }
            int orderId = int.Parse(val);
            DialogResult dialogResult =
               MessageBox.Show("Are you sure you want to delete this client?",
                               "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new OrdersRepo();
            repo.DeleteOrder(orderId);
            ReadOrders();
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
            CustomerChoice form = new CustomerChoice();
            this.Close();
            form.Show();
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trackbtn_Click(object sender, EventArgs e)
        {
            ShipmentMenu shipmentMenu = new ShipmentMenu();
            this.Close();
            shipmentMenu.Show();
        }

        private void trackbtn_Click_1(object sender, EventArgs e)
        {
            ShipmentMenu shipmentMenu = new ShipmentMenu();
            this.Close();
            shipmentMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
