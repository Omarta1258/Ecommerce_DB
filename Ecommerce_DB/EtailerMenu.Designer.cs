namespace LAKERS_SUCK
{
    partial class EtailerMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            etailerTable = new DataGridView();
            CB = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)etailerTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.FromArgb(30, 90, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(611, 68);
            label1.TabIndex = 0;
            label1.Text = "List of E-Tailers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = Color.FromArgb(50, 120, 200);
            button1.Location = new Point(11, 67);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(139, 28);
            button1.TabIndex = 1;
            button1.Text = "Add E-Tailer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(50, 120, 200);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 90, 170);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F);
            button2.ForeColor = Color.FromArgb(50, 120, 200);
            button2.Location = new Point(316, 67);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(139, 28);
            button2.TabIndex = 2;
            button2.Text = "Edit E-Tailer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
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
            button3.Location = new Point(461, 67);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(139, 28);
            button3.TabIndex = 3;
            button3.Text = "Delete E-Tailer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // etailerTable
            // 
            etailerTable.AllowUserToAddRows = false;
            etailerTable.AllowUserToDeleteRows = false;
            etailerTable.AllowUserToResizeColumns = false;
            etailerTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 220, 209);
            dataGridViewCellStyle1.SelectionForeColor = Color.SaddleBrown;
            etailerTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            etailerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            etailerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            etailerTable.BackgroundColor = Color.FromArgb(247, 238, 221);
            etailerTable.BorderStyle = BorderStyle.None;
            etailerTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            etailerTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(247, 238, 221);
            etailerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            etailerTable.ColumnHeadersHeight = 33;
            etailerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            etailerTable.Columns.AddRange(new DataGridViewColumn[] { CB });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle3.SelectionForeColor = Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            etailerTable.DefaultCellStyle = dataGridViewCellStyle3;
            etailerTable.EnableHeadersVisualStyles = false;
            etailerTable.GridColor = Color.SaddleBrown;
            etailerTable.Location = new Point(11, 99);
            etailerTable.Margin = new Padding(3, 2, 3, 2);
            etailerTable.MultiSelect = false;
            etailerTable.Name = "etailerTable";
            etailerTable.ReadOnly = true;
            etailerTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(190, 120, 80);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(247, 238, 221);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            etailerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            etailerTable.RowHeadersVisible = false;
            etailerTable.RowHeadersWidth = 51;
            etailerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            etailerTable.Size = new Size(590, 172);
            etailerTable.TabIndex = 5;
            // 
            // CB
            // 
            CB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CB.HeaderText = "";
            CB.Name = "CB";
            CB.ReadOnly = true;
            CB.Width = 30;
            // 
            // EtailerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 238, 221);
            ClientSize = new Size(611, 282);
            Controls.Add(etailerTable);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(627, 321);
            Name = "EtailerMenu";
            Text = "EtailerMenu";
            Load += EtailerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)etailerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView etailerTable;
        private DataGridViewCheckBoxColumn CB;
    }
}