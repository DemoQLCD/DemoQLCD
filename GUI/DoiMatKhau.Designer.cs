namespace GUI
{
    partial class DoiMatKhau
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
            textBoxMatKhauCu = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxMatKhauMoi = new TextBox();
            textBoxXacNhanMatKhau = new TextBox();
            label4 = new Label();
            buttonDoiMatKhau = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // textBoxMatKhauCu
            // 
            textBoxMatKhauCu.Location = new Point(316, 112);
            textBoxMatKhauCu.Margin = new Padding(2);
            textBoxMatKhauCu.Name = "textBoxMatKhauCu";
            textBoxMatKhauCu.Size = new Size(248, 30);
            textBoxMatKhauCu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu cũ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu mới :";
            // 
            // textBoxMatKhauMoi
            // 
            textBoxMatKhauMoi.Location = new Point(316, 163);
            textBoxMatKhauMoi.Margin = new Padding(2);
            textBoxMatKhauMoi.Name = "textBoxMatKhauMoi";
            textBoxMatKhauMoi.Size = new Size(252, 30);
            textBoxMatKhauMoi.TabIndex = 4;
            // 
            // textBoxXacNhanMatKhau
            // 
            textBoxXacNhanMatKhau.Location = new Point(316, 223);
            textBoxXacNhanMatKhau.Margin = new Padding(2);
            textBoxXacNhanMatKhau.Name = "textBoxXacNhanMatKhau";
            textBoxXacNhanMatKhau.Size = new Size(252, 30);
            textBoxXacNhanMatKhau.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 225);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 6;
            label4.Text = "Xác nhận mật khẩu :";
            // 
            // buttonDoiMatKhau
            // 
            buttonDoiMatKhau.BackColor = Color.Red;
            buttonDoiMatKhau.Location = new Point(250, 302);
            buttonDoiMatKhau.Margin = new Padding(2);
            buttonDoiMatKhau.Name = "buttonDoiMatKhau";
            buttonDoiMatKhau.Size = new Size(126, 54);
            buttonDoiMatKhau.TabIndex = 7;
            buttonDoiMatKhau.Text = "Đổi";
            buttonDoiMatKhau.UseVisualStyleBackColor = false;
            buttonDoiMatKhau.Click += buttonDoiMatKhau_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(452, 302);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 54);
            button1.TabIndex = 8;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 414);
            Controls.Add(button1);
            Controls.Add(buttonDoiMatKhau);
            Controls.Add(label4);
            Controls.Add(textBoxXacNhanMatKhau);
            Controls.Add(textBoxMatKhauMoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMatKhauCu);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxMatKhauCu;
        private Label label2;
        private Label label3;
        private TextBox textBoxMatKhauMoi;
        private TextBox textBoxXacNhanMatKhau;
        private Label label4;
        private Button buttonDoiMatKhau;
        private Button button1;
    }
}