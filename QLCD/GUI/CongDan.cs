using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CongDan : Form
    {
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string ThuongTru { get; set; }

        public CongDan()
        {
            InitializeComponent();
        }

        private void CongDan_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu vào các điều khiển
            txtCCCD.Text = CCCD;
            txtTen.Text = HoTen;
            txtGioiTinh.Text = GioiTinh;
            DateNgaySinh.Value = NgaySinh;
            txtQueQuan.Text = QueQuan;
            txtThuongTru.Text = ThuongTru;
        }
    }
}
