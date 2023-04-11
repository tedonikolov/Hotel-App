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
    internal class ClientRepo
    {
        private static NpgsqlCommand command;
        public static void save(Client client)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Client\"(\"egn\",\"Fullname\",\"Phonenumber\",\"Email\") VALUES ('" + client.egn + "','" + client.fullname + "','" + client.phoneNumber + "','" + client.email + "')";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(Client client)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Client\" WHERE \"ID_client\"={client.id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Client> getall()
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Client\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new List<Client>();
            while (reader.Read())
            {
                result.Add(new Client(
                        id: (int)reader["ID_client"],
                        fullname: (string)reader["Fullname"],
                        phoneNumber: (string)reader["Phonenumber"],
                        email: (string)reader["Email"],
                        egn: (string)reader["egn"]));
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
            command.CommandText = $"SELECT \"Fullname\" as \"Клиент\", \"egn\" as \"ЕГН\", \"Phonenumber\" as \"Телефон\", \"Email\" as \"Поща\" FROM \"Client\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }

        public static DataTable getTable(String col, String search)
        {
            DataTable table = new DataTable();

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            String column = "";
            switch (col)
            {
                case "Телефон":
                    column = "\"Phonenumber\"";
                    break;
                case "Поща":
                    column = "\"Email\"";
                    break;
                case "Клиент":
                    column = "\"Fullname\"";
                    break;
                case "ЕГН":
                    column = "\"egn\"";
                    break;
            }
            command.CommandText = $"SELECT \"Fullname\" as \"Клиент\", \"egn\" as \"ЕГН\", \"Phonenumber\" as \"Телефон\", \"Email\" as \"Поща\" FROM \"Client\" WHERE " + column + " LiKE '%" + search + "%'";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }

        public static void update(Client client)
        {
            List<Client> clients = getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;

            Boolean flag = true;

            foreach (Client c in clients)
            {
                if (c.id == client.id)
                {
                    command.CommandText = $"UPDATE \"Client\" SET \"Fullname\"='" + client.fullname + "' WHERE \"ID_client\"=" + client.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Client\" SET \"Phonenumber\"='" + client.phoneNumber + "' WHERE \"ID_client\"=" + client.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Client\" SET \"Email\"='" + client.email + "' WHERE \"ID_client\"=" + client.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Client\" SET \"egn\"='" + client.egn + "' WHERE \"ID_client\"=" + client.id;
                    command.ExecuteNonQuery();

                    flag = false;
                    connection.Close();
                }
            }
            
            if (flag)
            {
                save(client);
            }


            connection.Close();

        }
    }
}
