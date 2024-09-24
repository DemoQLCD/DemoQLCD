using DAL;
using Neo4j.Driver;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDAL;

        public TaiKhoanBLL(IDriver neo4jDriver) // Pass IDriver in the constructor
        {
            _taiKhoanDAL = new TaiKhoanDAL(neo4jDriver);
        }

        public async Task<bool> TestConnection()
        {
            return await _taiKhoanDAL.TestConnection();
        }

        public async Task<bool> Login(string maNV, string matKhau)
        {
            return await _taiKhoanDAL.Login(maNV, matKhau);
        }
    }
}
