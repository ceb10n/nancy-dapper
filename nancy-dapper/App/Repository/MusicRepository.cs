using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using nancy_dapper.App.Model;

namespace nancy_dapper.App.Repository
{
    public class MusicRepository
    {
        private readonly string connString = "Server=server;Database=database;Uid=user;Pwd=password;";

        public IEnumerable<Music> All()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                return conn.Query<Music>("select * from Music");
            }
        }
    }
}