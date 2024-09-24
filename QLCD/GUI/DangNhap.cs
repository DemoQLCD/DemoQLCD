using System;
using System.Windows.Forms;
using BLL;
using Neo4j.Driver; // Ensure this is included for IDriver

namespace GUI
{
    public partial class DangNhap : Form
    {
        private TaiKhoanBLL _taiKhoanBLL; // Declare the variable
        private IDriver _neo4jDriver; // Declare the Neo4j driver variable

        public DangNhap()
        {
            InitializeComponent();
            btnDangNhap.Click += new EventHandler(btnDangNhap_Click);
            _neo4jDriver = GraphDatabase.Driver("neo4j://localhost:7687", AuthTokens.Basic("neo4j", "123456")); // Update with your Neo4j credentials
            _taiKhoanBLL = new TaiKhoanBLL(_neo4jDriver);
        }

        private async void btnDangNhap_Click(object? sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra kết nối trước khi đăng nhập
            bool isConnected = await _taiKhoanBLL.TestConnection();
            if (isConnected)
            {
                MessageBox.Show("Kết nối đến cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tiến hành kiểm tra thông tin đăng nhập
                bool isValidUser = await _taiKhoanBLL.Login(maNV, matKhau);

                if (isValidUser)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Mở form chính
                    this.Hide();
                    FormMain mainForm = new FormMain();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

