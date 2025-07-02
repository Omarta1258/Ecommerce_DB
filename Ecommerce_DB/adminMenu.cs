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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LAKERS_SUCK
{
    public partial class adminMenu : Form
    {
        private string adminName;

        public adminMenu(int id)
        {
            InitializeComponent();
            var repo = new CustomerCartRepo();
            this.adminName = repo.GetShipmentById(id).Fname;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {adminName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the EmployeeChoice form
            EmployeeChoice employeeChoice = new EmployeeChoice();
            employeeChoice.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsMenu products = new ProductsMenu();
            products.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Open the EtailerMenu form
            EtailerMenu etailerMenu = new EtailerMenu();
            etailerMenu.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Open the CustomerMenu form
            ManufacturerMenu manufacturermenu = new ManufacturerMenu();
            manufacturermenu.ShowDialog();
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerChoice customerChoice = new CustomerChoice();
            customerChoice.ShowDialog();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(247, 238, 221);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.FromArgb(50, 120, 200);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddressMenu addressMenu = new AddressMenu();
            addressMenu.ShowDialog();
        }
    }
}
