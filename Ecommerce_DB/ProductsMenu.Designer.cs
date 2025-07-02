namespace LAKERS_SUCK
{
    partial class ProductsMenu
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
            productsTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 59);
            label1.TabIndex = 0;
            label1.Text = "Products Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnAdd.Location = new Point(11, 61);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Product";
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
            btnEdit.Location = new Point(473, 61);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 28);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Product";
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
            btnDelete.Location = new Point(618, 61);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // productsTable
            // 
            productsTable.AllowUserToAddRows = false;
            productsTable.AllowUserToDeleteRows = false;
            productsTable.AllowUserToResizeColumns = false;
            productsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.SelectionForeColor = Color.SaddleBrown;
            productsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            productsTable.BorderStyle = BorderStyle.None;
            productsTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            productsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(247, 238, 221);
            productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productsTable.ColumnHeadersHeight = 33;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            productsTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productsTable.DefaultCellStyle = dataGridViewCellStyle3;
            productsTable.EnableHeadersVisualStyles = false;
            productsTable.GridColor = Color.SaddleBrown;
            productsTable.Location = new Point(11, 93);
            productsTable.Margin = new Padding(3, 2, 3, 2);
            productsTable.MultiSelect = false;
            productsTable.Name = "productsTable";
            productsTable.ReadOnly = true;
            productsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            productsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            productsTable.RowHeadersVisible = false;
            productsTable.RowHeadersWidth = 51;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(747, 286);
            productsTable.TabIndex = 1;
            productsTable.CellClick += productsTable_CellClick;
            productsTable.CellContentClick += productsTable_CellContentClick;
            productsTable.CellPainting += productsTable_CellPainting;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // backbtn
            // 
            backbtn.Cursor = Cursors.Hand;
            backbtn.FlatAppearance.BorderColor = Color.FromArgb(247, 238, 221);
            backbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 238, 221);
            backbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 238, 221);
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Times New Roman", 12F);
            backbtn.ForeColor = Color.White;
            backbtn.Image = Properties.Resources.brown;
            backbtn.Location = new Point(11, 11);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(31, 34);
            backbtn.TabIndex = 6;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ProductsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(768, 389);
            Controls.Add(backbtn);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(productsTable);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(627, 321);
            Name = "ProductsMenu";
            Text = "ProductsMenu";
            Load += ProductsMenu_Load;
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView productsTable;
        private DataGridViewCheckBoxColumn CB;
        private Button backbtn;
    }
}