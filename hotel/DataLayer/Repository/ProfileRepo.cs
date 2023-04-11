using hotel.DataLayer.Entity;
using hotel.DataLayer.Repository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Repository
{
    internal class ProfileRepo
    {
        private static NpgsqlCommand command;
        public static void save(Profile profile)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Profile\"(\"Username\",\"Password\",\"role_id\") VALUES ('" + profile.username + "','"+profile.password+"',"+profile.role.id+")";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(Profile profile)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Profile\" WHERE \"ID_profile\"={profile.id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Profile> getall()
        {
            List<Role> roles = RoleRepo.getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Profile\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new List<Profile>();
            while (reader.Read())
            {
                foreach (Role role in roles)
                {
                    if(role.id== (int)reader["role_id"])
                    result.Add(new Profile(
                        id: (int)reader["ID_profile"],
                        username: (string)reader["Username"],
                        password: (string)reader["Password"],
                        role: role));
                }
            }


            reader.Close();
            connection.Close();

            return result;
        }
        public static DataTable getTable()
        {
            DataTable table = new DataTable();

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT \"ID_profile\" as \"ID\", \"Username\" as \"Потребител\", \"Password\" as \"Парола\" FROM \"Profile\" WHERE \"ID_profile\"!=1";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }
        public static void update(Profile profile)
        {
            List<Profile> profiles = getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;

            Boolean flag = true;

            foreach (Profile p in profiles)
            {
                if (p.id == profile.id)
                {
                    command.CommandText = $"UPDATE \"Profile\" SET \"Username\"='" + profile.username + "' WHERE \"ID_profile\"=" + profile.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Profile\" SET \"Password\"='" + profile.password + "' WHERE \"ID_profile\"=" + profile.id;
                    command.ExecuteNonQuery();
                    flag = false;
                    connection.Close();
                }
            }

            if (flag)
            {
                save(profile);
            }


            connection.Close();

        }
    }
}
