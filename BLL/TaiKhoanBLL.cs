using DAL;
using Neo4j.Driver;
using Neo4jClient.Cypher;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDAL;
        private IDriver _neo4jDriver;

        public TaiKhoanBLL(IDriver neo4jDriver) // Pass IDriver in the constructor
        {
            _neo4jDriver = neo4jDriver;
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
