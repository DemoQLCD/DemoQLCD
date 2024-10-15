namespace GUI
{
    partial class Khaisinh
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtMaSoTo = new TextBox();
            txtHovaTen = new TextBox();
            txtGioiTinh = new TextBox();
            txtDanToc = new TextBox();
            txtNguoiDangKy = new TextBox();
            txtQuocTichMe = new TextBox();
            txtHoTenMe = new TextBox();
            txtQuocTichCha = new TextBox();
            txtHoTenCha = new TextBox();
            txtNoiSinh = new TextBox();
            txtQuocTich = new TextBox();
            dtpNgayThangNamSinh = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label14 = new Label();
            label15 = new Label();
            txtDanTocCha = new TextBox();
            txtDanTocMe = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(260, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "GIẤY KHAI SINH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 1;
            label2.Text = "MaSoTo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 69);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "Họ và Tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 136);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 17);
            label5.TabIndex = 4;
            label5.Text = "Ngày Tháng Năm Sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 169);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 5;
            label6.Text = "Dân Tộc :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 6;
            label7.Text = "Quốc tịch :";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(352, 69);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 7;
            label8.Text = "Nơi Sinh :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(352, 98);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 8;
            label9.Text = "Họ Tên Cha :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(356, 169);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 17);
            label10.TabIndex = 9;
            label10.Text = "Họ Tên Mẹ :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(352, 135);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(105, 17);
            label11.TabIndex = 10;
            label11.Text = "Quốc Tịch Cha :";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(356, 204);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 17);
            label12.TabIndex = 11;
            label12.Text = "Quốc Tịch Mẹ :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(56, 204);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(111, 17);
            label13.TabIndex = 12;
            label13.Text = "Người Đăng Ký :";
            // 
            // txtMaSoTo
            // 
            txtMaSoTo.Location = new Point(148, 38);
            txtMaSoTo.Margin = new Padding(2, 1, 2, 1);
            txtMaSoTo.Name = "txtMaSoTo";
            txtMaSoTo.Size = new Size(121, 25);
            txtMaSoTo.TabIndex = 13;
            // 
            // txtHovaTen
            // 
            txtHovaTen.Location = new Point(148, 69);
            txtHovaTen.Margin = new Padding(2, 1, 2, 1);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(121, 25);
            txtHovaTen.TabIndex = 14;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(148, 101);
            txtGioiTinh.Margin = new Padding(2, 1, 2, 1);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(121, 25);
            txtGioiTinh.TabIndex = 15;
            // 
            // txtDanToc
            // 
            txtDanToc.Location = new Point(148, 169);
            txtDanToc.Margin = new Padding(2, 1, 2, 1);
            txtDanToc.Name = "txtDanToc";
            txtDanToc.Size = new Size(121, 25);
            txtDanToc.TabIndex = 16;
            // 
            // txtNguoiDangKy
            // 
            txtNguoiDangKy.Location = new Point(182, 204);
            txtNguoiDangKy.Margin = new Padding(2, 1, 2, 1);
            txtNguoiDangKy.Name = "txtNguoiDangKy";
            txtNguoiDangKy.Size = new Size(121, 25);
            txtNguoiDangKy.TabIndex = 17;
            // 
            // txtQuocTichMe
            // 
            txtQuocTichMe.Location = new Point(473, 205);
            txtQuocTichMe.Margin = new Padding(2, 1, 2, 1);
            txtQuocTichMe.Name = "txtQuocTichMe";
            txtQuocTichMe.Size = new Size(121, 25);
            txtQuocTichMe.TabIndex = 18;
            // 
            // txtHoTenMe
            // 
            txtHoTenMe.Location = new Point(473, 169);
            txtHoTenMe.Margin = new Padding(2, 1, 2, 1);
            txtHoTenMe.Name = "txtHoTenMe";
            txtHoTenMe.Size = new Size(121, 25);
            txtHoTenMe.TabIndex = 19;
            // 
            // txtQuocTichCha
            // 
            txtQuocTichCha.Location = new Point(473, 132);
            txtQuocTichCha.Margin = new Padding(2, 1, 2, 1);
            txtQuocTichCha.Name = "txtQuocTichCha";
            txtQuocTichCha.Size = new Size(121, 25);
            txtQuocTichCha.TabIndex = 20;
            // 
            // txtHoTenCha
            // 
            txtHoTenCha.Location = new Point(473, 98);
            txtHoTenCha.Margin = new Padding(2, 1, 2, 1);
            txtHoTenCha.Name = "txtHoTenCha";
            txtHoTenCha.Size = new Size(121, 25);
            txtHoTenCha.TabIndex = 21;
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.Location = new Point(473, 67);
            txtNoiSinh.Margin = new Padding(2, 1, 2, 1);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(121, 25);
            txtNoiSinh.TabIndex = 22;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(473, 35);
            txtQuocTich.Margin = new Padding(2, 1, 2, 1);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(121, 25);
            txtQuocTich.TabIndex = 23;
            // 
            // dtpNgayThangNamSinh
            // 
            dtpNgayThangNamSinh.Location = new Point(159, 135);
            dtpNgayThangNamSinh.Margin = new Padding(2, 1, 2, 1);
            dtpNgayThangNamSinh.Name = "dtpNgayThangNamSinh";
            dtpNgayThangNamSinh.Size = new Size(189, 25);
            dtpNgayThangNamSinh.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(618, 63);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(105, 52);
            button1.TabIndex = 25;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(618, 131);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(105, 48);
            button2.TabIndex = 26;
            button2.Text = "Làm Mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(356, 240);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(86, 17);
            label14.TabIndex = 27;
            label14.Text = "Dân Tộc Cha";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(356, 271);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(82, 17);
            label15.TabIndex = 28;
            label15.Text = "Dân Tộc Mẹ";
            // 
            // txtDanTocCha
            // 
            txtDanTocCha.Location = new Point(473, 240);
            txtDanTocCha.Margin = new Padding(2, 1, 2, 1);
            txtDanTocCha.Name = "txtDanTocCha";
            txtDanTocCha.Size = new Size(121, 25);
            txtDanTocCha.TabIndex = 29;
            // 
            // txtDanTocMe
            // 
            txtDanTocMe.Location = new Point(473, 271);
            txtDanTocMe.Margin = new Padding(2, 1, 2, 1);
            txtDanTocMe.Name = "txtDanTocMe";
            txtDanTocMe.Size = new Size(121, 25);
            txtDanTocMe.TabIndex = 30;
            // 
            // Khaisinh
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(808, 387);
            Controls.Add(txtDanTocMe);
            Controls.Add(txtDanTocCha);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpNgayThangNamSinh);
            Controls.Add(txtQuocTich);
            Controls.Add(txtNoiSinh);
            Controls.Add(txtHoTenCha);
            Controls.Add(txtQuocTichCha);
            Controls.Add(txtHoTenMe);
            Controls.Add(txtQuocTichMe);
            Controls.Add(txtNguoiDangKy);
            Controls.Add(txtDanToc);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtHovaTen);
            Controls.Add(txtMaSoTo);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Khaisinh";
            Text = "Khaisinh";
            Load += Khaisinh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtMaSoTo;
        private TextBox txtHovaTen;
        private TextBox txtGioiTinh;
        private TextBox txtDanToc;
        private TextBox txtNguoiDangKy;
        private TextBox txtQuocTichMe;
        private TextBox txtHoTenMe;
        private TextBox txtQuocTichCha;
        private TextBox txtHoTenCha;
        private TextBox txtNoiSinh;
        private TextBox txtQuocTich;
        private DateTimePicker dtpNgayThangNamSinh;
        private Button button1;
        private Button button2;
        private Label label14;
        private Label label15;
        private TextBox txtDanTocCha;
        private TextBox txtDanTocMe;
    }
}