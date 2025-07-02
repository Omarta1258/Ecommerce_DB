namespace LAKERS_SUCK
{
    partial class EmployeeChoice
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            label5 = new Label();
            employeeTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            SuspendLayout();
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
            btnAdd.Location = new Point(12, 304);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add new Employee";
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
            btnEdit.Location = new Point(205, 304);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(167, 28);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Employee";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            btnEdit.MouseMove += btnEdit_MouseMove;
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
            btnDelete.Location = new Point(399, 304);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 28);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(799, 73);
            label1.TabIndex = 4;
            label1.Text = "Welcome to the Employee Page!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
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
            button4.Location = new Point(612, 123);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(153, 28);
            button4.TabIndex = 7;
            button4.Text = "E-Tailers";
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
            button5.Font = new Font("Times New Roman", 12F);
            button5.ForeColor = Color.FromArgb(50, 120, 200);
            button5.Location = new Point(612, 243);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(153, 28);
            button5.TabIndex = 8;
            button5.Text = "Manufacturers";
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
            button6.Font = new Font("Times New Roman", 12F);
            button6.ForeColor = Color.FromArgb(50, 120, 200);
            button6.Location = new Point(612, 183);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(153, 28);
            button6.TabIndex = 9;
            button6.Text = "Products";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.MouseEnter += button6_MouseEnter;
            button6.MouseLeave += button6_MouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Times New Roman", 16F);
            label4.ForeColor = Color.FromArgb(30, 90, 170);
            label4.Location = new Point(583, 73);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 11;
            label4.Text = "More Options";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16F);
            label5.ForeColor = Color.FromArgb(30, 90, 170);
            label5.Location = new Point(10, 72);
            label5.Name = "label5";
            label5.Size = new Size(485, 26);
            label5.TabIndex = 10;
            label5.Text = "Employees List";
            label5.Click += label5_Click;
            // 
            // employeeTable
            // 
            employeeTable.AllowUserToAddRows = false;
            employeeTable.AllowUserToDeleteRows = false;
            employeeTable.AllowUserToResizeColumns = false;
            employeeTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.SelectionForeColor = Color.SaddleBrown;
            employeeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            employeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            employeeTable.BorderStyle = BorderStyle.None;
            employeeTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            employeeTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle6.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(247, 238, 221);
            employeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            employeeTable.ColumnHeadersHeight = 33;
            employeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            employeeTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            employeeTable.DefaultCellStyle = dataGridViewCellStyle7;
            employeeTable.EnableHeadersVisualStyles = false;
            employeeTable.GridColor = Color.SaddleBrown;
            employeeTable.Location = new Point(12, 100);
            employeeTable.Margin = new Padding(3, 2, 3, 2);
            employeeTable.MultiSelect = false;
            employeeTable.Name = "employeeTable";
            employeeTable.ReadOnly = true;
            employeeTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            employeeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            employeeTable.RowHeadersVisible = false;
            employeeTable.RowHeadersWidth = 51;
            employeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeTable.Size = new Size(578, 190);
            employeeTable.TabIndex = 12;
            employeeTable.CellContentClick += employeesTable_CellContentClick_1;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // EmployeeChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(799, 343);
            Controls.Add(employeeTable);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(764, 382);
            Name = "EmployeeChoice";
            Text = "EmployeeChoice";
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label4;
        private Label label5;
        private DataGridView employeeTable;
        private DataGridViewCheckBoxColumn CB;
    }
}