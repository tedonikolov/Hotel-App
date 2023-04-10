using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Repository
{
    internal class TypeRepo
    {
        private static NpgsqlCommand command;
        public static void save(Type type)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Type\"(\"Type\",\"Price\",\"People\") VALUES ('" + type.type + "','"+type.price+"',"+type.people+")";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(Type type)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Type\" WHERE \"ID_type\"={type.id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Type> getall()
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Type\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new List<Type>();
            while (reader.Read())
            {
                result.Add(new Type(
                id: (int)reader["ID_type"],
                type: (string)reader["Type"],
                price: (Decimal)reader["Price"],
                people: (int)reader["People"]));
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
            command.CommandText = $"SELECT \"ID_type\" as \"ID\", \"Type\" as \"Вид\", \"Price\" as \"Цена за нощувка\", \"People\" as \"Брой хора\" FROM \"Type\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }

        public static void update(Type type)
        {
            List<Type> types = getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
               
            Boolean flag=true;

            foreach(Type t in types)
            {
                if (t.id == type.id)
                {
                    
                    command.CommandText = $"UPDATE \"Type\" SET \"Price\"=" + (int)type.price + " WHERE \"ID_type\"=" + type.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Type\" SET \"Type\"='" + type.type + "' WHERE \"ID_type\"=" + type.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Type\" SET \"People\"=" + type.people + " WHERE \"ID_type\"=" + type.id;
                    command.ExecuteNonQuery();


                    flag = false;
                    connection.Close();
                }
            }

            if (flag)
            {
                save(type);
            }


            connection.Close();

        }
    }
}
