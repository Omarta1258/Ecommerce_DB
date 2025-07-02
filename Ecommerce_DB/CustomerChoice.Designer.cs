namespace LAKERS_SUCK
{
    partial class CustomerChoice
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
            label1 = new Label();
            customerTable = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            sortCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)customerTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(748, 71);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Customer Page!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerTable
            // 
            customerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerTable.Location = new Point(10, 103);
            customerTable.Margin = new Padding(3, 2, 3, 2);
            customerTable.MultiSelect = false;
            customerTable.Name = "customerTable";
            customerTable.RowHeadersVisible = false;
            customerTable.RowHeadersWidth = 51;
            customerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerTable.Size = new Size(522, 188);
            customerTable.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 12F);
            btnAdd.ForeColor = Color.FromArgb(50, 120, 200);
            btnAdd.Location = new Point(10, 304);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += btnAdd_MouseEnter;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 12F);
            btnEdit.ForeColor = Color.FromArgb(50, 120, 200);
            btnEdit.Location = new Point(194, 304);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(153, 28);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Customer";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.ForeColor = Color.FromArgb(50, 120, 200);
            btnDelete.Location = new Point(379, 304);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(50, 120, 200);
            button4.Location = new Point(561, 123);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 28);
            button4.TabIndex = 5;
            button4.Text = "Address";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(50, 120, 200);
            button5.Location = new Point(561, 183);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(153, 28);
            button5.TabIndex = 6;
            button5.Text = "Orders";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(50, 120, 200);
            button6.Location = new Point(561, 243);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(153, 28);
            button6.TabIndex = 7;
            button6.Text = "Payment";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.MouseEnter += button6_MouseEnter;
            button6.MouseLeave += button6_MouseLeave;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16F);
            label2.ForeColor = Color.FromArgb(30, 90, 170);
            label2.Location = new Point(10, 71);
            label2.Name = "label2";
            label2.Size = new Size(485, 26);
            label2.TabIndex = 8;
            label2.Text = "Customers List";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Times New Roman", 16F);
            label3.ForeColor = Color.FromArgb(30, 90, 170);
            label3.Location = new Point(532, 71);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 9;
            label3.Text = "More Options";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // sortCustomer
            // 
            sortCustomer.Cursor = Cursors.Hand;
            sortCustomer.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            sortCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            sortCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            sortCustomer.FlatStyle = FlatStyle.Flat;
            sortCustomer.Font = new Font("Times New Roman", 12F);
            sortCustomer.ForeColor = Color.FromArgb(50, 120, 200);
            sortCustomer.Location = new Point(194, 71);
            sortCustomer.Margin = new Padding(3, 2, 3, 2);
            sortCustomer.Name = "sortCustomer";
            sortCustomer.Size = new Size(192, 28);
            sortCustomer.TabIndex = 10;
            sortCustomer.Text = "Find Highest Spenders\r\n";
            sortCustomer.UseVisualStyleBackColor = true;
            sortCustomer.Click += sortCustomer_Click_1;
            // 
            // CustomerChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(748, 343);
            Controls.Add(sortCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(customerTable);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(764, 382);
            Name = "CustomerChoice";
            Text = "CustomerChoice";
            Load += CustomerChoice_Load;
            ((System.ComponentModel.ISupportInitialize)customerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView customerTable;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label3;
        private Button sortCustomer;
    }
}