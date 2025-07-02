namespace LAKERS_SUCK
{
    partial class PaymentMenu
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
            backbtn = new Button();
            paymentTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)paymentTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(833, 66);
            label1.TabIndex = 0;
            label1.Text = "Payment Menu";
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
            btnAdd.Location = new Point(10, 68);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Payment Details";
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
            btnEdit.Location = new Point(549, 68);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 49);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Payment Details";
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
            btnDelete.Location = new Point(688, 68);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Payment Details";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
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
            backbtn.Location = new Point(12, 18);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(31, 34);
            backbtn.TabIndex = 7;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // paymentTable
            // 
            paymentTable.AllowUserToAddRows = false;
            paymentTable.AllowUserToDeleteRows = false;
            paymentTable.AllowUserToResizeColumns = false;
            paymentTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle5.SelectionForeColor = Color.SaddleBrown;
            paymentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            paymentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paymentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            paymentTable.BorderStyle = BorderStyle.None;
            paymentTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            paymentTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle6.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(247, 238, 221);
            paymentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            paymentTable.ColumnHeadersHeight = 33;
            paymentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            paymentTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle7.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            paymentTable.DefaultCellStyle = dataGridViewCellStyle7;
            paymentTable.EnableHeadersVisualStyles = false;
            paymentTable.GridColor = Color.SaddleBrown;
            paymentTable.Location = new Point(10, 122);
            paymentTable.Margin = new Padding(3, 2, 3, 2);
            paymentTable.MultiSelect = false;
            paymentTable.Name = "paymentTable";
            paymentTable.ReadOnly = true;
            paymentTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            paymentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            paymentTable.RowHeadersVisible = false;
            paymentTable.RowHeadersWidth = 51;
            paymentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentTable.Size = new Size(812, 231);
            paymentTable.TabIndex = 8;
            paymentTable.CellContentClick += productsTable_CellContentClick;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // PaymentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(833, 362);
            Controls.Add(paymentTable);
            Controls.Add(backbtn);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(627, 321);
            Name = "PaymentMenu";
            Text = "PaymentMenu";
            Load += PaymentMenu_Load;
            ((System.ComponentModel.ISupportInitialize)paymentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button backbtn;
        private DataGridView paymentTable;
        private DataGridViewCheckBoxColumn CB;
    }
}