namespace LAKERS_SUCK
{
    partial class OrdersMenu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            backbtn = new Button();
            orderTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            trackbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)orderTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(611, 63);
            label1.TabIndex = 0;
            label1.Text = "Orders Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 12F);
            btnAdd.ForeColor = Color.FromArgb(50, 120, 200);
            btnAdd.Location = new Point(11, 65);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 28);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += btnAdd_MouseEnter;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
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
            btnEdit.Location = new Point(315, 65);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 28);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Order";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.ForeColor = Color.FromArgb(50, 120, 200);
            btnDelete.Location = new Point(460, 65);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // backbtn
            // 
            backbtn.Cursor = Cursors.Hand;
            backbtn.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            backbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            backbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Times New Roman", 12F);
            backbtn.ForeColor = Color.FromArgb(50, 120, 200);
            backbtn.Location = new Point(11, 11);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(139, 28);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // orderTable
            // 
            orderTable.AllowUserToAddRows = false;
            orderTable.AllowUserToDeleteRows = false;
            orderTable.AllowUserToResizeColumns = false;
            orderTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.SelectionForeColor = Color.SaddleBrown;
            orderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            orderTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            orderTable.BorderStyle = BorderStyle.None;
            orderTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            orderTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(247, 238, 221);
            orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            orderTable.ColumnHeadersHeight = 33;
            orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            orderTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            orderTable.DefaultCellStyle = dataGridViewCellStyle3;
            orderTable.EnableHeadersVisualStyles = false;
            orderTable.GridColor = Color.SaddleBrown;
            orderTable.Location = new Point(11, 97);
            orderTable.Margin = new Padding(3, 2, 3, 2);
            orderTable.MultiSelect = false;
            orderTable.Name = "orderTable";
            orderTable.ReadOnly = true;
            orderTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            orderTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            orderTable.RowHeadersVisible = false;
            orderTable.RowHeadersWidth = 51;
            orderTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderTable.Size = new Size(587, 164);
            orderTable.TabIndex = 6;
            orderTable.CellContentClick += productsTable_CellContentClick;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // trackbtn
            // 
            trackbtn.Cursor = Cursors.Hand;
            trackbtn.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            trackbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            trackbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            trackbtn.FlatStyle = FlatStyle.Flat;
            trackbtn.Font = new Font("Times New Roman", 12F);
            trackbtn.ForeColor = Color.FromArgb(50, 120, 200);
            trackbtn.Location = new Point(156, 65);
            trackbtn.Margin = new Padding(3, 2, 3, 2);
            trackbtn.Name = "trackbtn";
            trackbtn.Size = new Size(139, 28);
            trackbtn.TabIndex = 7;
            trackbtn.Text = "Track Orders";
            trackbtn.UseVisualStyleBackColor = true;
            trackbtn.Click += trackbtn_Click_1;
            // 
            // OrdersMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(611, 282);
            Controls.Add(trackbtn);
            Controls.Add(orderTable);
            Controls.Add(backbtn);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(627, 321);
            Name = "OrdersMenu";
            Text = "OrdersMenu";
            ((System.ComponentModel.ISupportInitialize)orderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button backbtn;
        private DataGridView orderTable;
        private DataGridViewCheckBoxColumn CB;
        private Button trackbtn;
    }
}