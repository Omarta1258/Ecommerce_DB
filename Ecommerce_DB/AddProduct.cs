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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int productID = 0;

        public void EditClient(Product product)
        {
            this.Text = "Edit Product";
            this.label1.Text = "Edit Product";

            this.lbID.Text = "" + product.ProductID;
            this.textBox1.Text = product.Name;
            this.textBox2.Text = product.Price.ToString();
            this.textBox3.Text = product.Description;
            this.textBox4.Text = product.CategoryName;
            this.textBox5.Text = product.ManufacturerID.ToString();

            this.productID = product.ProductID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID = 0;
            product.Name = textBox1.Text;
            product.Price = decimal.Parse(textBox2.Text);
            product.Description = textBox3.Text;
            product.CategoryName = textBox4.Text;
            product.ManufacturerID = int.Parse(textBox5.Text);

            var repo = new ProductRepository();
            if (product.ProductID == 0)
            {
                repo.AddProduct(product);
            }
            else
            {
                repo.UpdateProduct(product);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
