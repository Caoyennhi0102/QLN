namespace QLN
{
    partial class Form1
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
            lbText = new Label();
            lbHovaTen = new Label();
            txtHovaTen = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbNgaySinh = new Label();
            label1 = new Label();
            txtGioiTinh = new TextBox();
            lbMaSoSinhVien = new Label();
            txtmssv = new TextBox();
            lbNganhHoc = new Label();
            txtNganhHoc = new TextBox();
            lbDTB = new Label();
            txtDTB = new TextBox();
            btSave = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Location = new Point(324, 9);
            lbText.Name = "lbText";
            lbText.Size = new Size(108, 15);
            lbText.TabIndex = 0;
            lbText.Text = "NHẬP THÔNG TIN ";
            // 
            // lbHovaTen
            // 
            lbHovaTen.AutoSize = true;
            lbHovaTen.Location = new Point(22, 73);
            lbHovaTen.Name = "lbHovaTen";
            lbHovaTen.Size = new Size(62, 15);
            lbHovaTen.TabIndex = 1;
            lbHovaTen.Text = "Họ và Tên ";
            // 
            // txtHovaTen
            // 
            txtHovaTen.Location = new Point(116, 73);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(176, 23);
            txtHovaTen.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Location = new Point(20, 112);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(64, 15);
            lbNgaySinh.TabIndex = 4;
            lbNgaySinh.Text = "Ngày Sinh ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 159);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Giới Tính ";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(116, 172);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(100, 23);
            txtGioiTinh.TabIndex = 6;
            // 
            // lbMaSoSinhVien
            // 
            lbMaSoSinhVien.AutoSize = true;
            lbMaSoSinhVien.Location = new Point(12, 210);
            lbMaSoSinhVien.Name = "lbMaSoSinhVien";
            lbMaSoSinhVien.Size = new Size(95, 15);
            lbMaSoSinhVien.TabIndex = 7;
            lbMaSoSinhVien.Text = "Mã Số Sinh Viên ";
            // 
            // txtmssv
            // 
            txtmssv.Location = new Point(116, 210);
            txtmssv.Name = "txtmssv";
            txtmssv.Size = new Size(100, 23);
            txtmssv.TabIndex = 8;
            // 
            // lbNganhHoc
            // 
            lbNganhHoc.AutoSize = true;
            lbNganhHoc.Location = new Point(20, 274);
            lbNganhHoc.Name = "lbNganhHoc";
            lbNganhHoc.Size = new Size(71, 15);
            lbNganhHoc.TabIndex = 9;
            lbNganhHoc.Text = "Ngành Học ";
            // 
            // txtNganhHoc
            // 
            txtNganhHoc.Location = new Point(116, 266);
            txtNganhHoc.Name = "txtNganhHoc";
            txtNganhHoc.Size = new Size(100, 23);
            txtNganhHoc.TabIndex = 10;
            // 
            // lbDTB
            // 
            lbDTB.AutoSize = true;
            lbDTB.Location = new Point(12, 317);
            lbDTB.Name = "lbDTB";
            lbDTB.Size = new Size(98, 15);
            lbDTB.TabIndex = 11;
            lbDTB.Text = "Điểm Trung Bình ";
            // 
            // txtDTB
            // 
            txtDTB.Location = new Point(116, 312);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(100, 23);
            txtDTB.TabIndex = 12;
            // 
            // btSave
            // 
            btSave.Location = new Point(222, 317);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 13;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 104);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btSave);
            Controls.Add(txtDTB);
            Controls.Add(lbDTB);
            Controls.Add(txtNganhHoc);
            Controls.Add(lbNganhHoc);
            Controls.Add(txtmssv);
            Controls.Add(lbMaSoSinhVien);
            Controls.Add(txtGioiTinh);
            Controls.Add(label1);
            Controls.Add(lbNgaySinh);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtHovaTen);
            Controls.Add(lbHovaTen);
            Controls.Add(lbText);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbText;
        private Label lbHovaTen;
        private TextBox txtHovaTen;
        private DateTimePicker dateTimePicker1;
        private Label lbNgaySinh;
        private Label label1;
        private TextBox txtGioiTinh;
        private Label lbMaSoSinhVien;
        private TextBox txtmssv;
        private Label lbNganhHoc;
        private TextBox txtNganhHoc;
        private Label lbDTB;
        private TextBox txtDTB;
        private Button btSave;
        private DataGridView dataGridView1;
    }
}
