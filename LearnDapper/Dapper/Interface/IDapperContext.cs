using System.Data;

namespace LearnDapper.Dapper.Interface
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
