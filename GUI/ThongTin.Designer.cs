namespace GUI
{
    partial class ThongTin
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
            datagridviewDSCD = new DataGridView();
            btnLoadKhaiSinh = new Button();
            btnLoadCongDan = new Button();
            btnLoadHoKhau = new Button();
            btnLoadHonNhan = new Button();
            btnLoadTamTru = new Button();
            btnLoadBaoTu = new Button();
            button1 = new Button();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridviewDSCD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(483, 86);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin chung";
            // 
            // datagridviewDSCD
            // 
            datagridviewDSCD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewDSCD.Location = new Point(38, 157);
            datagridviewDSCD.Name = "datagridviewDSCD";
            datagridviewDSCD.RowHeadersWidth = 51;
            datagridviewDSCD.Size = new Size(1124, 383);
            datagridviewDSCD.TabIndex = 1;
            // 
            // btnLoadKhaiSinh
            // 
            btnLoadKhaiSinh.BackColor = Color.Lime;
            btnLoadKhaiSinh.Location = new Point(550, 12);
            btnLoadKhaiSinh.Name = "btnLoadKhaiSinh";
            btnLoadKhaiSinh.Size = new Size(117, 47);
            btnLoadKhaiSinh.TabIndex = 2;
            btnLoadKhaiSinh.Text = "Khai Sinh";
            btnLoadKhaiSinh.UseVisualStyleBackColor = false;
            btnLoadKhaiSinh.Click += btnLoadKhaiSinh_Click;
            // 
            // btnLoadCongDan
            // 
            btnLoadCongDan.BackColor = Color.Red;
            btnLoadCongDan.Location = new Point(426, 12);
            btnLoadCongDan.Name = "btnLoadCongDan";
            btnLoadCongDan.Size = new Size(117, 47);
            btnLoadCongDan.TabIndex = 3;
            btnLoadCongDan.Text = "Công Dân";
            btnLoadCongDan.UseVisualStyleBackColor = false;
            btnLoadCongDan.Click += btnLoadCongDan_Click;
            // 
            // btnLoadHoKhau
            // 
            btnLoadHoKhau.BackColor = Color.FromArgb(0, 192, 0);
            btnLoadHoKhau.Location = new Point(674, 12);
            btnLoadHoKhau.Name = "btnLoadHoKhau";
            btnLoadHoKhau.Size = new Size(117, 47);
            btnLoadHoKhau.TabIndex = 4;
            btnLoadHoKhau.Text = "Hộ Khẩu";
            btnLoadHoKhau.UseVisualStyleBackColor = false;
            btnLoadHoKhau.Click += btnLoadHoKhau_Click;
            // 
            // btnLoadHonNhan
            // 
            btnLoadHonNhan.BackColor = Color.FromArgb(255, 192, 255);
            btnLoadHonNhan.Location = new Point(798, 12);
            btnLoadHonNhan.Name = "btnLoadHonNhan";
            btnLoadHonNhan.Size = new Size(117, 47);
            btnLoadHonNhan.TabIndex = 5;
            btnLoadHonNhan.Text = "Hôn Nhân";
            btnLoadHonNhan.UseVisualStyleBackColor = false;
            btnLoadHonNhan.Click += btnLoadHonNhan_Click;
            // 
            // btnLoadTamTru
            // 
            btnLoadTamTru.BackColor = Color.Yellow;
            btnLoadTamTru.Location = new Point(921, 12);
            btnLoadTamTru.Name = "btnLoadTamTru";
            btnLoadTamTru.Size = new Size(117, 47);
            btnLoadTamTru.TabIndex = 6;
            btnLoadTamTru.Text = "Tạm trú";
            btnLoadTamTru.UseVisualStyleBackColor = false;
            btnLoadTamTru.Click += btnLoadTamTru_Click;
            // 
            // btnLoadBaoTu
            // 
            btnLoadBaoTu.BackColor = SystemColors.ControlDark;
            btnLoadBaoTu.Location = new Point(1045, 12);
            btnLoadBaoTu.Name = "btnLoadBaoTu";
            btnLoadBaoTu.Size = new Size(117, 47);
            btnLoadBaoTu.TabIndex = 7;
            btnLoadBaoTu.Text = "Báo Tử";
            btnLoadBaoTu.UseVisualStyleBackColor = false;
            btnLoadBaoTu.Click += btnLoadBaoTu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(1026, 560);
            button1.Name = "button1";
            button1.Size = new Size(136, 50);
            button1.TabIndex = 8;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.Green;
            btnXuatExcel.ForeColor = SystemColors.ButtonHighlight;
            btnXuatExcel.Location = new Point(883, 560);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(136, 50);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // ThongTin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg5;
            ClientSize = new Size(1180, 622);
            Controls.Add(btnXuatExcel);
            Controls.Add(button1);
            Controls.Add(btnLoadBaoTu);
            Controls.Add(btnLoadTamTru);
            Controls.Add(btnLoadHonNhan);
            Controls.Add(btnLoadHoKhau);
            Controls.Add(btnLoadCongDan);
            Controls.Add(btnLoadKhaiSinh);
            Controls.Add(datagridviewDSCD);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ThongTin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongTin";
            ((System.ComponentModel.ISupportInitialize)datagridviewDSCD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView datagridviewDSCD;
        private Button btnLoadKhaiSinh;
        private Button btnLoadCongDan;
        private Button btnLoadHoKhau;
        private Button btnLoadHonNhan;
        private Button btnLoadTamTru;
        private Button btnLoadBaoTu;
        private Button button1;
        private Button btnXuatExcel;
    }
}