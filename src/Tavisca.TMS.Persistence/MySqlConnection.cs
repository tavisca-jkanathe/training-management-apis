using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Persistence
{
    class MySqlConnectionConfig
    {
      
        private static MySqlConnection _connection = null;
        public MySqlConnectionConfig()
        {
            
        }
        public static MySqlConnection GetConnection()
        {
            var sqlUsername = Environment.GetEnvironmentVariable("sql_username", EnvironmentVariableTarget.Machine);
            var sqlPassword = Environment.GetEnvironmentVariable("sql_password", EnvironmentVariableTarget.Machine);

            var dbName = "tms_db";
            var _connectionString = $"server=localhost;port=3306;Database={dbName}; uid={ sqlUsername };pwd= { sqlPassword }; convert zero datetime=True;";
            Console.WriteLine(_connectionString);
            if (_connection == null)
                _connection = new MySqlConnection(_connectionString);
            return _connection;
        }
    }
}
