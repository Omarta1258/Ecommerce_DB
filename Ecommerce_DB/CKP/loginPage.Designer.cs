namespace LAKERS_SUCK
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCustomer = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(620, 186);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our E-commerce Online Store!\r\nYou're currently accessing as an Admin!\r\nPlease choose which user you would like to access\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.FromArgb(50, 120, 200);
            btnCustomer.Location = new Point(20, 220);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(211, 42);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            btnCustomer.MouseEnter += btnCustomer_MouseEnter;
            btnCustomer.MouseLeave += btnCustomer_MouseLeave;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(50, 120, 200);
            button2.Location = new Point(390, 220);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(211, 42);
            button2.TabIndex = 2;
            button2.Text = "Employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(620, 325);
            Controls.Add(button2);
            Controls.Add(btnCustomer);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(621, 364);
            Name = "WelcomePage";
            Text = "Pacman Store";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCustomer;
        private Button button2;
    }
}
