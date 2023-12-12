using DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DapperServices : IDapperServices<Branch>
    {
        private string constring = "Server=LAPTOP-46NPMGS0\\SQLEXPRESS;Database=DapperCRUD;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
        private SqlConnection con;
        public DapperServices()
        {
            con = new SqlConnection(constring);
        }
        public async Task<IEnumerable<Branch>> ReadAllAsync()
        {
            var sql = "EXEC sp_Branch";
            var users = await con.QueryAsync<Branch>(sql);
            return users;
        }

    }
}
