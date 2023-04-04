using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel.DataLayer.Entity;
using Npgsql;

namespace hotel.DataLayer.Repository
{
    internal class RoleRepo
    {
        private static NpgsqlCommand command;
        public static void save(Role role)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Role\" (role) VALUES ('"+role.role+"')";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void update(Role role)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"UPDATE \"Role\" SET \"ID_role\"='" + 2 + "' WHERE \"ID_role\"="+role.id;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(Role role)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Role\" WHERE \"ID_role\"={role.id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Role> getall()
        {
            var result = new List<Role>();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Role\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Role(
                    id: (int)reader["ID_role"],
                    role: (string)reader["role"]));
            }
        

            reader.Close();
            connection.Close();

            return result;
        }

        public static Role getById(int id)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Role\" WHERE id="+id;
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new Role(
                    id: (int)reader["ID_role"],
                    role: (string)reader["role"]);

            reader.Close();
            connection.Close();

            return result;
        }
    }
}
