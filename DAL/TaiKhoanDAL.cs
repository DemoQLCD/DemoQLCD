using Neo4j.Driver;
using System.Threading.Tasks;

public class TaiKhoanDAL
{
    private readonly IDriver _neo4jDriver;
    private TaiKhoanDAL _taiKhoanDAL;
    public TaiKhoanDAL(IDriver neo4jDriver)
    {
        _neo4jDriver = neo4jDriver;
    }

    // Method to test the connection to Neo4j
    public async Task<bool> TestConnection()
    {
        try
        {
            using (var session = _neo4jDriver.AsyncSession())
            {
                await session.RunAsync("RETURN 1"); // Simple query to check the connection
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    // Method for logging in
    public async Task<bool> Login(string maNV, string matKhau)
    {
        var taiKhoan = await GetTaiKhoanAsync(maNV, matKhau);
        return taiKhoan != null; // Return true if a valid account is found
    }

    public async Task<TaiKhoan> GetTaiKhoanAsync(string maNV, string matKhau)
    {
        using (var session = _neo4jDriver.AsyncSession())
        {
            var cursor = await session.RunAsync("MATCH (t:TaiKhoan {MaNV: $maNV, MatKhau: $matKhau}) RETURN t", new { maNV, matKhau });
            var results = await cursor.ToListAsync();

            if (results.Count == 0)
                return null;

            var record = results[0];
            var taiKhoanNode = record["t"].As<INode>();

            return new TaiKhoan
            {
                MaNV = taiKhoanNode.Properties["MaNV"].As<string>(),
                MatKhau = taiKhoanNode.Properties["MatKhau"].As<string>(),
                HoTen = taiKhoanNode.Properties["HoTen"].As<string>(),
                ChiNhanh = taiKhoanNode.Properties["ChiNhanh"].As<string>(),
                SoDT = taiKhoanNode.Properties["SoDT"].As<string>(),
                LoaiTK = taiKhoanNode.Properties["LoaiTK"].As<string>()
            };
        }
    }
    public async Task<TaiKhoan> GetTaiKhoanInfo(string maNV)
    {
        using (var session = _neo4jDriver.AsyncSession())
        {
            var result = await session.RunAsync("MATCH (t:TaiKhoan {MaNV: $maNV}) RETURN t", new { maNV });

            var records = await result.ToListAsync(); // Lấy tất cả các bản ghi vào danh sách
            if (records.Count > 0)
            {
                var taiKhoanNode = records[0]["t"].As<INode>();
                return new TaiKhoan
                {
                    MaNV = taiKhoanNode.Properties["MaNV"].As<string>(),
                    MatKhau = taiKhoanNode.Properties["MatKhau"].As<string>(),
                    HoTen = taiKhoanNode.Properties["HoTen"].As<string>(),
                    ChiNhanh = taiKhoanNode.Properties["ChiNhanh"].As<string>(),
                    SoDT = taiKhoanNode.Properties["SoDT"].As<string>(),
                    LoaiTK = taiKhoanNode.Properties["LoaiTK"].As<string>(),
                };
            }
            return null; // Trả về null nếu không có bản ghi nào
        }
    }
    public async Task<bool> ChangePassword(string maNV, string matKhauCu, string matKhauMoi)
    {
        using (var session = _neo4jDriver.AsyncSession())
        {
            var result = await session.RunAsync("MATCH (t:TaiKhoan {MaNV: $maNV}) WHERE t.MatKhau = $matKhauCu SET t.MatKhau = $matKhauMoi RETURN COUNT(t) AS count", new { maNV, matKhauCu, matKhauMoi });

            var records = await result.ToListAsync();

            // Kiểm tra xem có bản ghi nào không
            if (records.Count == 0)
            {
                // Không có bản ghi nào thỏa mãn điều kiện
                return false;
            }

            // Lấy giá trị COUNT(t)
            return records[0]["count"].As<int>() > 0; // Nếu có bản ghi được cập nhật
        }
    }
}
