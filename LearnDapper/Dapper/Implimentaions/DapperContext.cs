using LearnDapper.Dapper.Interface;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LearnDapper.Dapper.Implimentaions
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connString;
        public DapperContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
            _connString = _iConfiguration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connString);
    }
}
