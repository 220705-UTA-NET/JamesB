using Microsoft.Extensions.Logging;
using P1_Data.Model;
using System.Data.SqlClient;

namespace P1_IRepository
{
    public class ToSQLDB : IRepository
    {

        //Fields
        private readonly string _connectionString;
        private readonly ILogger<ToSQLDB> _logger;

        //Constructors
        public ToSQLDB(string connectionString, ILogger<ToSQLDB> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        //Methods
        public async Task<IEnumerable<Actor>> GetActorsAsync()
        {
            List<Actor> Result = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string cmdText = "SELECT name, hpmax, attbonus, savebonus, damagedie FROM BOML.actor;";

            using SqlCommand cmd = new(cmdText, connection);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                string name = reader.GetString(0);
                int hpmax = reader.GetInt32(1);
                int attbonus = reader.GetInt32(2);
                int savebonus = reader.GetInt32(3);
                int damagedie = reader.GetInt32(4);

                Actor tmpActor = new Actor(name, hpmax, attbonus, savebonus, damagedie);
                Result.Add(tmpActor);
            }

            await connection.CloseAsync();

            _logger.LogInformation("Executed GetActorsAsync(), returned {0} results", Result.Count);

            return Result;
        } 

        public async Task<IEnumerable<Map>> GetMapDescriptionAsync(int xloc, int yloc)
        {
            List<Map> Result = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string cmdText = "SELECT Description FROM BOML.rooms WHERE Xloc = '0' AND Yloc = '0';";

            using SqlCommand cmd = new(cmdText, connection);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                string description = reader.GetString(0);
            }

            await connection.CloseAsync();

            _logger.LogInformation("Executed GetMapDescriptionAsync(), returned {0} results", Result.Count);

            return Result;
        }


    }
}