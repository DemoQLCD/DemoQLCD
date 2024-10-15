namespace GUI
{
    partial class CongDan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DateNgaySinh = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCCCD = new TextBox();
            txtTen = new TextBox();
            txtGioiTinh = new TextBox();
            txtQueQuan = new TextBox();
            txtThuongTru = new TextBox();
            btnCapNhatChiTietCongDan = new Button();
            btnSuaChiTietCongDan = new Button();
            btnTroVeTruoc = new Button();
            btnVeTrangChu = new Button();
            btnXoaChiTietCongDan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(502, 69);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết công dân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 213);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 175);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 256);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính :";
            // 
            // DateNgaySinh
            // 
            DateNgaySinh.Location = new Point(594, 168);
            DateNgaySinh.Name = "DateNgaySinh";
            DateNgaySinh.Size = new Size(340, 27);
            DateNgaySinh.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 170);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày Sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 213);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 6;
            label6.Text = "Quê Quán :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(470, 256);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 7;
            label7.Text = "Địa Chỉ Thường Trú :";
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Location = new Point(201, 175);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(219, 27);
            txtCCCD.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(201, 213);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(219, 27);
            txtTen.TabIndex = 9;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BorderStyle = BorderStyle.FixedSingle;
            txtGioiTinh.Location = new Point(201, 256);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(219, 27);
            txtGioiTinh.TabIndex = 10;
            // 
            // txtQueQuan
            // 
            txtQueQuan.BorderStyle = BorderStyle.FixedSingle;
            txtQueQuan.Location = new Point(594, 201);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(341, 27);
            txtQueQuan.TabIndex = 11;
            // 
            // txtThuongTru
            // 
            txtThuongTru.BorderStyle = BorderStyle.FixedSingle;
            txtThuongTru.Location = new Point(638, 249);
            txtThuongTru.Name = "txtThuongTru";
            txtThuongTru.Size = new Size(297, 27);
            txtThuongTru.TabIndex = 12;
            // 
            // btnCapNhatChiTietCongDan
            // 
            btnCapNhatChiTietCongDan.BackColor = Color.FromArgb(0, 192, 0);
            btnCapNhatChiTietCongDan.Location = new Point(677, 339);
            btnCapNhatChiTietCongDan.Name = "btnCapNhatChiTietCongDan";
            btnCapNhatChiTietCongDan.Size = new Size(114, 58);
            btnCapNhatChiTietCongDan.TabIndex = 13;
            btnCapNhatChiTietCongDan.Text = "Cập nhật";
            btnCapNhatChiTietCongDan.UseVisualStyleBackColor = false;
            btnCapNhatChiTietCongDan.Click += btnCapNhatChiTietCongDan_Click;
            // 
            // btnSuaChiTietCongDan
            // 
            btnSuaChiTietCongDan.BackColor = Color.Lime;
            btnSuaChiTietCongDan.Location = new Point(273, 341);
            btnSuaChiTietCongDan.Name = "btnSuaChiTietCongDan";
            btnSuaChiTietCongDan.Size = new Size(117, 58);
            btnSuaChiTietCongDan.TabIndex = 14;
            btnSuaChiTietCongDan.Text = "Sửa";
            btnSuaChiTietCongDan.UseVisualStyleBackColor = false;
            btnSuaChiTietCongDan.Click += btnSuaChiTietCongDan_Click;
            // 
            // btnTroVeTruoc
            // 
            btnTroVeTruoc.Location = new Point(1022, 497);
            btnTroVeTruoc.Name = "btnTroVeTruoc";
            btnTroVeTruoc.Size = new Size(119, 37);
            btnTroVeTruoc.TabIndex = 15;
            btnTroVeTruoc.Text = "Trở về";
            btnTroVeTruoc.UseVisualStyleBackColor = true;
            // 
            // btnVeTrangChu
            // 
            btnVeTrangChu.Location = new Point(881, 497);
            btnVeTrangChu.Name = "btnVeTrangChu";
            btnVeTrangChu.Size = new Size(119, 37);
            btnVeTrangChu.TabIndex = 16;
            btnVeTrangChu.Text = "Trang Chủ";
            btnVeTrangChu.UseVisualStyleBackColor = true;
            btnVeTrangChu.Click += btnVeTrangChu_Click;
            // 
            // btnXoaChiTietCongDan
            // 
            btnXoaChiTietCongDan.BackColor = Color.Red;
            btnXoaChiTietCongDan.Location = new Point(471, 343);
            btnXoaChiTietCongDan.Name = "btnXoaChiTietCongDan";
            btnXoaChiTietCongDan.Size = new Size(127, 54);
            btnXoaChiTietCongDan.TabIndex = 17;
            btnXoaChiTietCongDan.Text = "Xóa";
            btnXoaChiTietCongDan.UseVisualStyleBackColor = false;
            btnXoaChiTietCongDan.Click += btnXoaChiTietCongDan_Click;
            // 
            // CongDan
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = Properties.Resources.bg4;
            ClientSize = new Size(1164, 550);
            Controls.Add(btnXoaChiTietCongDan);
            Controls.Add(btnVeTrangChu);
            Controls.Add(btnTroVeTruoc);
            Controls.Add(btnSuaChiTietCongDan);
            Controls.Add(btnCapNhatChiTietCongDan);
            Controls.Add(txtThuongTru);
            Controls.Add(txtQueQuan);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtTen);
            Controls.Add(txtCCCD);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DateNgaySinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CongDan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết Công dân";
            Load += CongDan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DateNgaySinh;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCCCD;
        private TextBox txtTen;
        private TextBox txtGioiTinh;
        private TextBox txtQueQuan;
        private TextBox txtThuongTru;
        private Button btnCapNhatChiTietCongDan;
        private Button btnSuaChiTietCongDan;
        private Button btnTroVeTruoc;
        private Button btnVeTrangChu;
        private Button btnXoaChiTietCongDan;
    }
}