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
    public partial class ProductsMenu : Form
    {
        public ProductsMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Create a DataTable to hold product data  
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("CategoryName");
            dataTable.Columns.Add("ManufacturerID");

            // Assuming there's a ProductRepository to fetch product data  
            var repo = new ProductRepository();
            var products = repo.GetProducts();

            foreach (var product in products)
            {
                var row = dataTable.NewRow();

                row["ProductID"] = product.ProductID;
                row["Name"] = product.Name;
                row["Price"] = product.Price;
                row["Description"] = product.Description;
                row["CategoryName"] = product.CategoryName;
                row["ManufacturerID"] = product.ManufacturerID;
                dataTable.Rows.Add(row);
            }

            // Assuming there's a DataGridView named productsTable in the form  
            this.productsTable.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the product list after adding a new product
                LoadProducts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.productsTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }
            int productID = int.Parse(val);

            var repo = new ProductRepository();
            var product = repo.GetProductById(productID);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }
            AddProduct addProductForm = new AddProduct();
            addProductForm.EditClient(product);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the product list after editing a product
                LoadProducts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.productsTable.SelectedRows[0].Cells[1].Value.ToString();
            if (val == null || val.Length == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            int productID = int.Parse(val);

            DialogResult dialogresult =
                MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.No)
            {
                return;
            }
            var repo = new ProductRepository();
            repo.DeleteProduct(productID);
            LoadProducts();
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



        private int selectedRowIndex = -1; // Store the last clicked row

        private void productsTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Target only first column
            {
                e.PaintBackground(e.CellBounds, true); // Keep default cell background

                // Define checkbox dimensions
                int boxSize = 14;
                Rectangle checkboxRect = new Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width - boxSize) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - boxSize) / 2,
                    boxSize, boxSize
                );

                using (Pen borderPen = new Pen(Color.FromArgb(139, 69, 19), 2)) // Border thickness & color
                {
                    e.Graphics.DrawRectangle(borderPen, checkboxRect); // Draw checkbox border
                }

                // Fill the checkbox with the background color (247, 238, 221)
                using (Brush bgBrush = new SolidBrush(Color.FromArgb(247, 238, 221)))
                {
                    e.Graphics.FillRectangle(bgBrush, checkboxRect);
                }

                // Check if the row is selected, then overlay the checkbox with another color
                if (e.RowIndex == selectedRowIndex)
                {
                    using (Brush fillBrush = new SolidBrush(Color.FromArgb(139, 69, 19))) // Filled color
                    {
                        e.Graphics.FillRectangle(fillBrush, checkboxRect);
                    }
                }

                e.Handled = true; // Prevent default checkbox rendering
            }
        }


        private void productsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                selectedRowIndex = e.RowIndex; // Track the clicked row
                productsTable.Invalidate(); // Refresh to update visuals
            }
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

        private void ProductsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}