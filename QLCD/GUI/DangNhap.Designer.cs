namespace GUI
{
    partial class DangNhap
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
            txtMaNV = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(246, 112);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(226, 27);
            txtMaNV.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(246, 170);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(226, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(294, 258);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(130, 33);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "button1";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += this.btnDangNhap_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtMaNV);
            Name = "DangNhap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaNV;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}
