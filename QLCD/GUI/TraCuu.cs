using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Neo4j.Driver;

namespace GUI
{
    public partial class TraCuu : Form
    {
        private IDriver _neo4jDriver;
        public string MaNV { get; set; }
        public TraCuu()
        {
            InitializeComponent();
            _neo4jDriver = Neo4jConnectionManager.GetDriver();
        }

        private async void TraCuu_Load(object sender, EventArgs e)
        {
            await LoadAllCitizens();
        }
        private async Task LoadAllCitizens() // Đảm bảo phương thức là async và trả về Task
        {
            var result = await _neo4jDriver.AsyncSession().RunAsync("MATCH (c:CongDan) RETURN c");
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("Họ và tên");
            dataTable.Columns.Add("Giới tính");
            dataTable.Columns.Add("Ngày sinh");
            dataTable.Columns.Add("Quê quán");
            dataTable.Columns.Add("Thường trú");

            while (await result.FetchAsync())
            {
                var citizen = result.Current["c"].As<INode>();
                dataTable.Rows.Add(
                    citizen.Properties["cccd"].As<string>(),
                    citizen.Properties["hoten"].As<string>(),
                    citizen.Properties["gioitinh"].As<string>(),
                    citizen.Properties["ngaysinh"].As<DateTime>().ToString("dd/MM/yyyy"),
                    citizen.Properties["quequan"].As<string>(),
                    citizen.Properties["thuongtru"].As<string>()
                );
            }

            dataCD.DataSource = dataTable; // Cập nhật tên DataGridView ở đây
        }

        private async Task SearchCitizen(string keyword) // Đảm bảo phương thức là async và trả về Task
        {
            var query = "MATCH (c:CongDan) WHERE c.hoten CONTAINS $keyword OR c.cccd = $cccd RETURN c";
            var parameters = new { keyword = keyword, cccd = keyword };

            var result = await _neo4jDriver.AsyncSession().RunAsync(query, parameters);
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("Họ và tên");
            dataTable.Columns.Add("Giới tính");
            dataTable.Columns.Add("Ngày sinh");
            dataTable.Columns.Add("Quê quán");
            dataTable.Columns.Add("Thường trú");

            while (await result.FetchAsync())
            {
                var citizen = result.Current["c"].As<INode>();
                dataTable.Rows.Add(
                    citizen.Properties["cccd"].As<string>(),
                    citizen.Properties["hoten"].As<string>(),
                    citizen.Properties["gioitinh"].As<string>(),
                    citizen.Properties["ngaysinh"].As<DateTime>().ToString("dd/MM/yyyy"),
                    citizen.Properties["quequan"].As<string>(),
                    citizen.Properties["thuongtru"].As<string>()
                );
            }

            dataCD.DataSource = dataTable; // Cập nhật tên DataGridView ở đây
            dataCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Kiểm tra nếu không có dữ liệu
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy công dân nào với từ khóa đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim(); // Lấy giá trị từ ô tìm kiếm

            if (!string.IsNullOrEmpty(keyword)) // Kiểm tra nếu ô tìm kiếm không rỗng
            {
                await SearchCitizen(keyword); // Gọi phương thức tìm kiếm
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm."); // Thông báo nếu ô tìm kiếm rỗng
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(MaNV); // Đảm bảo MaNV được truyền vào

            // Hiện form chính
            formMain.Show();

            // Đóng form TraCuu
            this.Close();
        }

        private async void LtnLammoi_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của ô tìm kiếm
            txtTimKiem.Clear();

            // Tải lại dữ liệu đầy đủ vào DataGridView
            await LoadAllCitizens();

        }
    }
}
