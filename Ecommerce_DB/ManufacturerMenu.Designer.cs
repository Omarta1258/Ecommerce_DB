namespace LAKERS_SUCK
{
    partial class ManufacturerMenu
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
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            manufacturerTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)manufacturerTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(611, 73);
            label1.TabIndex = 0;
            label1.Text = "Manufacturer Menu";
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
            btnAdd.Location = new Point(11, 76);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 28);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Manufacturer";
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
            btnEdit.Location = new Point(262, 76);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 28);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Manufacturer";
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
            btnDelete.Location = new Point(434, 76);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Manufacturer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // manufacturerTable
            // 
            manufacturerTable.AllowUserToAddRows = false;
            manufacturerTable.AllowUserToDeleteRows = false;
            manufacturerTable.AllowUserToResizeColumns = false;
            manufacturerTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.SelectionForeColor = Color.SaddleBrown;
            manufacturerTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            manufacturerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            manufacturerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manufacturerTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            manufacturerTable.BorderStyle = BorderStyle.None;
            manufacturerTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            manufacturerTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle6.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(247, 238, 221);
            manufacturerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            manufacturerTable.ColumnHeadersHeight = 33;
            manufacturerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            manufacturerTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            manufacturerTable.DefaultCellStyle = dataGridViewCellStyle7;
            manufacturerTable.EnableHeadersVisualStyles = false;
            manufacturerTable.GridColor = Color.SaddleBrown;
            manufacturerTable.Location = new Point(11, 108);
            manufacturerTable.Margin = new Padding(3, 2, 3, 2);
            manufacturerTable.MultiSelect = false;
            manufacturerTable.Name = "manufacturerTable";
            manufacturerTable.ReadOnly = true;
            manufacturerTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            manufacturerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            manufacturerTable.RowHeadersVisible = false;
            manufacturerTable.RowHeadersWidth = 51;
            manufacturerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            manufacturerTable.Size = new Size(590, 163);
            manufacturerTable.TabIndex = 5;
            manufacturerTable.CellContentClick += manufacturerTable_CellContentClick;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // ManufacturerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(611, 282);
            Controls.Add(manufacturerTable);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(627, 321);
            Name = "ManufacturerMenu";
            Text = "ManufacturerMenu";
            Load += ManufacturerMenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)manufacturerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView manufacturerTable;
        private DataGridViewCheckBoxColumn CB;
    }
}