namespace LAKERS_SUCK
{
    partial class ShipmentMenu
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
            shipmentTable = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            backbtn = new Button();
            assnEmp = new Button();
            ewsTable = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)shipmentTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ewsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1518, 63);
            label1.TabIndex = 1;
            label1.Text = "Shipment Details ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // shipmentTable
            // 
            shipmentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shipmentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shipmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shipmentTable.Location = new Point(12, 110);
            shipmentTable.Margin = new Padding(3, 2, 3, 2);
            shipmentTable.MaximumSize = new Size(1101, 654);
            shipmentTable.MultiSelect = false;
            shipmentTable.Name = "shipmentTable";
            shipmentTable.RowHeadersVisible = false;
            shipmentTable.RowHeadersWidth = 51;
            shipmentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shipmentTable.Size = new Size(1101, 654);
            shipmentTable.TabIndex = 10;
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
            btnDelete.Location = new Point(1364, 78);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Shipment\r\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            btnEdit.Location = new Point(1364, 46);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(142, 28);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Shipment";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
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
            btnAdd.Location = new Point(12, 43);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 28);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Shipment";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            backbtn.Location = new Point(12, 11);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(139, 28);
            backbtn.TabIndex = 12;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // assnEmp
            // 
            assnEmp.Cursor = Cursors.Hand;
            assnEmp.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            assnEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            assnEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            assnEmp.FlatStyle = FlatStyle.Flat;
            assnEmp.Font = new Font("Times New Roman", 12F);
            assnEmp.ForeColor = Color.FromArgb(50, 120, 200);
            assnEmp.Location = new Point(12, 78);
            assnEmp.Margin = new Padding(3, 2, 3, 2);
            assnEmp.Name = "assnEmp";
            assnEmp.Size = new Size(159, 28);
            assnEmp.TabIndex = 13;
            assnEmp.Text = "Assign Employee";
            assnEmp.UseVisualStyleBackColor = true;
            assnEmp.Click += assnEmp_Click;
            // 
            // ewsTable
            // 
            ewsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ewsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ewsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ewsTable.Location = new Point(1247, 152);
            ewsTable.Margin = new Padding(3, 2, 3, 2);
            ewsTable.MaximumSize = new Size(280, 900);
            ewsTable.MultiSelect = false;
            ewsTable.Name = "ewsTable";
            ewsTable.RowHeadersVisible = false;
            ewsTable.RowHeadersWidth = 51;
            ewsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ewsTable.Size = new Size(259, 612);
            ewsTable.TabIndex = 14;
            ewsTable.CellContentClick += ewsTable_CellContentClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 120, 200);
            label2.Location = new Point(1299, 125);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 15;
            label2.Text = "Stored Employees";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = Color.FromArgb(50, 120, 200);
            button1.Location = new Point(1119, 167);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 78);
            button1.TabIndex = 9;
            button1.Text = "Show All Assigned Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EmployeesAssigned;
            // 
            // ShipmentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(1518, 775);
            Controls.Add(label2);
            Controls.Add(ewsTable);
            Controls.Add(assnEmp);
            Controls.Add(backbtn);
            Controls.Add(shipmentTable);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1534, 814);
            Name = "ShipmentMenu";
            Text = "ShipmentMenu";
            Load += ShipmentMenu_Load;
            ((System.ComponentModel.ISupportInitialize)shipmentTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ewsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button trackbtn;
        private DataGridView shipmentTable;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button backbtn;
        private Button assnEmp;
        private DataGridView ewsTable;
        private Label label2;
        private Button button1;
    }
}