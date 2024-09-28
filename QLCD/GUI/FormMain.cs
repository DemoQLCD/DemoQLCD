using System;
using System.Windows.Forms;
using Neo4j.Driver;

namespace GUI
{
    public partial class FormMain : Form
    {
        private IDriver _neo4jDriver;
        public string MaNV { get; set; }  // Thuộc tính để lưu Mã NV

        public FormMain(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;  // Gán giá trị cho thuộc tính
            _neo4jDriver = GraphDatabase.Driver("neo4j://localhost:7687", AuthTokens.Basic("neo4j", "123456"));
        }


        private async void FormMain_Load(object sender, EventArgs e)
        {
            lb_MaNV.Text = $"Nhân viên: {MaNV}";
            await LoadSoDan();
        }

        private async Task LoadSoDan()
        {
            var result = await _neo4jDriver.AsyncSession().RunAsync("MATCH (c:CongDan) RETURN count(c) as SoDan");
            var record = await result.SingleAsync();
            int soDan = record["SoDan"].As<int>();
            lb_sodan.Text = $"Số dân: {soDan}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
