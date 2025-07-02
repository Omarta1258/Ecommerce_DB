using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;


namespace LAKERS_SUCK
{
    public partial class mainForm : Form
    {
        private Panel panel1;

        public mainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            // Initialize rectangle (panel)
            //panel1 = new Panel
            //{
            //    BackColor = Color.White,
            //    Size = new Size(400, 150) // Set initial size
            //};

            //this.Controls.Add(panel1);
            //this.Resize += mainForm_Resize; // Adjust panel on resize
            //this.FormClosing += mainForm_FormClosing;
        }

        //private void mainForm_Resize(object sender, EventArgs e)
        //{
        //    if (panel1 != null)
        //    {
        //        panel1.Size = new Size(Math.Min(400, this.ClientSize.Width / 3), Math.Min(150, this.ClientSize.Height / 6));

        //        panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2,
        //                                    (this.ClientSize.Height - panel1.Height) / 2);
        //    }
        //}



        // Paint method for custom drawing
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;

        //    // Background color
        //    this.BackColor = Color.WhiteSmoke;

        //    int centerX = this.ClientSize.Width / 2 - 200; // Adjusted position
        //    int centerY = this.ClientSize.Height / 2 - 150; // Adjusted position

        //    // Draw rounded login box
        //    using (Brush boxBrush = new SolidBrush(Color.White))
        //    using (Pen borderPen = new Pen(Color.LightGray, 2))
        //    {
        //        g.FillRectangle(boxBrush, centerX, centerY, 400, 350);
        //        g.DrawRectangle(borderPen, centerX, centerY, 400, 350);
        //    }

        //    // Draw Microsoft-style text
        //    using (Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold))
        //    using (Brush textBrush = new SolidBrush(Color.Black))
        //    {
        //        g.DrawString("Sign in", titleFont, textBrush, centerX + 130, centerY + 20);
        //    }

        //    using (Font descFont = new Font("Segoe UI", 10, FontStyle.Regular))
        //    {
        //        g.DrawString("Use your work or school account", descFont, Brushes.DarkGray, centerX + 70, centerY + 60);
        //    }
        //}


        // Handle form closing to show warning
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                // If "No" is clicked, cancel the form closing
                e.Cancel = true;
            }
        }

        // This method will be called when button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog when button1 is clicked
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the form?",
                "Close Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.Close(); // If Yes, close the form
            }
        }

        // This method opens the login form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim(); // Assuming textBox2 is the email input field 
            textBox1.Text.Trim();


            // Email validation using regex
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if email exists in the database
            if (!IsEmailExist(email))
            {
                MessageBox.Show("Email not found in the database. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If valid, pass email to loginForm
            loginForm loginform = new loginForm(email);
            loginform.Show();
            this.Hide();
        }

        // LinkLabel click (add functionality if needed)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        // Another button2 click (add functionality if needed)
        private void button2_Click(object sender, EventArgs e)
        {
        }

        // MainForm load event (if you need to initialize anything)
        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        // Label click event (if you need it for additional actions)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            registerForm registerform = new registerForm();
            registerform.Show();
            this.Hide();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //string email = textBox1.Text.Trim();

        //    //// Email validation using regex
        //    //if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        //    //{
        //    //    MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return;
        //    //}

        //    //// Check if email exists in the database
        //    //if (!IsEmailExist(email))
        //    //{
        //    //    MessageBox.Show("Email not found in the database. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return;
        //    //}

        //    //// If valid, pass email to loginForm
        //    //loginForm loginform = new loginForm(email);
        //    //loginform.Show();
        //    //this.Hide();
        //}

        private bool IsEmailExist(string email)
        {
            // Basic email format validation using regex
            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("The email address is not valid. Please enter a valid email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            bool exists = false;
            string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"; // Replace with actual connection string

            // Check if the email exists in the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM customerCart WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    // Ensure result is not null before casting
                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        exists = count > 0;
                    }
                    conn.Close();
                }
            }

            return exists;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}