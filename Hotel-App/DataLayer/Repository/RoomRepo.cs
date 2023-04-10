using hotel.DataLayer.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Repository
{
    internal class RoomRepo
    {
        private static NpgsqlCommand command;
        public static void save(Room room)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Room\"(\"ID_room\",\"Bathroom\",\"Type_id\") VALUES (" + room.id + "," + room.bathroom + "," + room.type.id + ")";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(Room room)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Room\" WHERE \"ID_room\"={room.id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Room> getall()
        {
            List<Type> types = TypeRepo.getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Room\" ORDER BY \"ID_room\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new List<Room>();
            while (reader.Read())
            {
                foreach (Type type in types)
                {
                    if (type.id == (int)reader["Type_id"])
                        result.Add(new Room(
                            id: (int)reader["ID_room"],
                            bathroom: (Boolean)reader["Bathroom"],
                            type: type));
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
            command.CommandText = $"SELECT \"ID_room\" as \"ID\", \"Type\".\"Type\" as \"Вид\", \"Bathroom\" as \"Баня\" FROM \"Room\" JOIN \"Type\" on \"Type\".\"ID_type\"=\"Room\".\"Type_id\" ORDER BY \"ID_room\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }
        public static void update(Room room)
        {
            List<Room> rooms = getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;

            Boolean flag = true;

            foreach (Room r in rooms)
            {
                if (r.id==room.id)
                {
                    command.CommandText = $"UPDATE \"Room\" SET \"Type_id\"=" + room.type.id + " WHERE \"ID_room\"=" + room.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Room\" SET \"Bathroom\"=" + room.bathroom + " WHERE \"ID_room\"=" + room.id;
                    command.ExecuteNonQuery();
                    flag = false;
                    connection.Close();
                }
            }

            if (flag)
            {
                save(room);
            }


            connection.Close();

        }
    }
}
