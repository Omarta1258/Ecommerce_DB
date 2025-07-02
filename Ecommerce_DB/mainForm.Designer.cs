namespace LAKERS_SUCK
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnAdd = new Button();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            btnEdit = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.SaddleBrown;
            textBox1.Location = new Point(11, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email@exmaple.com";
            textBox1.Size = new Size(364, 23);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 12F);
            btnAdd.ForeColor = Color.FromArgb(50, 120, 200);
            btnAdd.Location = new Point(271, 89);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Next";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = Color.FromArgb(50, 120, 200);
            button1.Location = new Point(161, 89);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(104, 28);
            button1.TabIndex = 8;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(4, 29);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 6;
            label2.Text = "Sign in";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F);
            button2.ForeColor = Color.FromArgb(50, 120, 200);
            button2.Location = new Point(11, 89);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(139, 28);
            button2.TabIndex = 12;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(175, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 155);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 8;
            label1.Text = "Sign in";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 23);
            textBox2.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 12F);
            btnEdit.ForeColor = Color.FromArgb(50, 120, 200);
            btnEdit.Location = new Point(19, 77);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 28);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Create account";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += label3_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 12F);
            button3.ForeColor = Color.FromArgb(50, 120, 200);
            button3.Location = new Point(149, 77);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(112, 28);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F);
            button4.ForeColor = Color.FromArgb(50, 120, 200);
            button4.Location = new Point(267, 77);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(112, 28);
            button4.TabIndex = 6;
            button4.Text = "Next";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnAdd_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(784, 361);
            Controls.Add(panel2);
            MinimumSize = new Size(627, 321);
            Name = "mainForm";
            Text = "mainForm";
            Load += mainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button btnAdd;
        private Button button1;
        private Label label2;
        private Button button2;
        private Panel panel2;
        private TextBox textBox2;
        private Button btnEdit;
        private Button button3;
        private Button button4;
        private Label label1;
        //private Panel panel1;
    }
}