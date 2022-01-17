using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linea195.Model;
using Npgsql;


namespace Linea195.Data.Repositories
{
    class PropertyRepositories : IPropertyRepositories
    {
        public Task<IEnumerable<Propertys>> GetProperty()
        {
            var cs = "Server=127.0.0.1;Port=5432;Database=Linea195;User=postgres;Password=98060751340";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * FROM property";
            var sql= cmd.ExecuteNonQuery();
            return sql;
        }

        public Task<bool> InsertImage(Propertys Propertys)
        {
            var cs = "Server=127.0.0.1;Port=5432;Database=Linea195;User=postgres;Password=98060751340";
            using var con = new NpgsqlConnection(cs);
            con.Open();
           var sql = @"INSERT INTO owner (name,adress,photo,birthday) values (@name,@adress,@photo,@birthday)";
            using var cmd = new NpgsqlCommand(sql,con);
            cmd.Parameters.AddWithValue()
        }

        public Task<bool> InsertProperty(Propertys Propertys)
        {
            var cs = "Server=127.0.0.1;Port=5432;Database=Linea195;User=postgres;Password=98060751340";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = @"INSERT INTO owner (name,adress,photo,birthday) values (@name,@adress,@photo,@birthday)";
            using var cmd = new NpgsqlCommand(sql,con);
            cmd.Parameters.AddWithValue()
        }

        public Task<bool> UpdatePrice(Propertys propertys)
        {
            var cs = "Server=127.0.0.1;Port=5432;Database=Linea195;User=postgres;Password=98060751340";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            var sql = @"UPDATE TABLE ";
            using var cmd = new NpgsqlCommand(sql, con);
        }

        public Task<bool> UpdateProperty(Propertys propertys)
        {
            var cs = "Server=127.0.0.1;Port=5432;Database=Linea195;User=postgres;Password=98060751340";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            var sql = @"UPDATE TABLE ";
            using var cmd = new NpgsqlCommand(sql, con);
        }
    }
}
