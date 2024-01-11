using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperASPNetCore.Context;

public class DapperContext
{
    private readonly string _connectionString;

    public DapperContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("SqlConnection") ?? throw new ApplicationException("The connection string is null");
    }

    public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
}
