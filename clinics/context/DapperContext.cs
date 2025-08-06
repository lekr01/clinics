using MySql.Data.MySqlClient;
using System.Data;

namespace clinics.context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _conectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _conectionString = _configuration.GetConnectionString("MySqlConnection");
        }

        public IDbConnection CreateConnection() => new MySqlConnection(_conectionString);
    }
}
