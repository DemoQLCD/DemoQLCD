namespace GUI
{
    partial class CongDanTu
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
            txtCCCD = new TextBox();
            txtNguyenNhan = new TextBox();
            txtCCCDCanBo = new TextBox();
            btnXacNhan = new Button();
            btnLamMoi = new Button();
            dtpNgayMat = new DateTimePicker();
            txtNgay = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(329, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "GIẤY BÁO TỬ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "CCCD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 178);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày Mất :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 254);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 3;
            label4.Text = "Nguyên Nhân :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 95);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 4;
            label5.Text = "Ngày ĐK :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 146);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 5;
            label6.Text = "Tháng ĐK :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 197);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 6;
            label7.Text = "Năm ĐK :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 260);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 7;
            label8.Text = "CCCD Cán Bộ :";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(156, 97);
            txtCCCD.Margin = new Padding(2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(150, 30);
            txtCCCD.TabIndex = 8;
            // 
            // txtNguyenNhan
            // 
            txtNguyenNhan.Location = new Point(156, 251);
            txtNguyenNhan.Margin = new Padding(2);
            txtNguyenNhan.Name = "txtNguyenNhan";
            txtNguyenNhan.Size = new Size(150, 30);
            txtNguyenNhan.TabIndex = 10;
            // 
            // txtCCCDCanBo
            // 
            txtCCCDCanBo.Location = new Point(544, 254);
            txtCCCDCanBo.Margin = new Padding(2);
            txtCCCDCanBo.Name = "txtCCCDCanBo";
            txtCCCDCanBo.Size = new Size(150, 30);
            txtCCCDCanBo.TabIndex = 14;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Red;
            btnXacNhan.ForeColor = Color.FromArgb(0, 0, 64);
            btnXacNhan.Location = new Point(221, 323);
            btnXacNhan.Margin = new Padding(2);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(133, 57);
            btnXacNhan.TabIndex = 15;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.ForeColor = Color.FromArgb(0, 64, 0);
            btnLamMoi.Location = new Point(389, 323);
            btnLamMoi.Margin = new Padding(2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(146, 57);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dtpNgayMat
            // 
            dtpNgayMat.Location = new Point(156, 178);
            dtpNgayMat.Margin = new Padding(2);
            dtpNgayMat.Name = "dtpNgayMat";
            dtpNgayMat.Size = new Size(232, 30);
            dtpNgayMat.TabIndex = 17;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(516, 97);
            txtNgay.Margin = new Padding(2);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(178, 30);
            txtNgay.TabIndex = 18;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(516, 147);
            txtThang.Margin = new Padding(2);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(178, 30);
            txtThang.TabIndex = 19;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(512, 197);
            txtNam.Margin = new Padding(2);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(182, 30);
            txtNam.TabIndex = 20;
            // 
            // CongDanTu
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 414);
            Controls.Add(txtNam);
            Controls.Add(txtThang);
            Controls.Add(txtNgay);
            Controls.Add(dtpNgayMat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXacNhan);
            Controls.Add(txtCCCDCanBo);
            Controls.Add(txtNguyenNhan);
            Controls.Add(txtCCCD);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "CongDanTu";
            Text = "CongDanTu";
            Load += CongDanTu_Load;
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
        private TextBox txtCCCD;
        private TextBox txtNguyenNhan;
        private TextBox txtCCCDCanBo;
        private Button btnXacNhan;
        private Button btnLamMoi;
        private DateTimePicker dtpNgayMat;
        private TextBox txtNgay;
        private TextBox txtThang;
        private TextBox txtNam;
    }
}