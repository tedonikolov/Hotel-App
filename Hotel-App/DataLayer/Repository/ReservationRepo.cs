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
    internal class ReservationRepo
    {
        private static NpgsqlCommand command;
        public static void save(Reservation reservation)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"INSERT INTO \"Reservation\"(\"Client_id\",\"Room_id\",\"Check_in\",\"Check_out\",\"Profile_id\",\"Price\")  VALUES (" + reservation.client.id + "," + reservation.room.id + ",'" + reservation.checkIn.Year + "-" + reservation.checkIn.Month+"-" + reservation.checkIn.Day + "','" + reservation.checkOut.Year + "-" + reservation.checkOut.Month + "-" + reservation.checkOut.Day + "'," + reservation.profile.id +",'"+reservation.price+ "')";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void delete(int id)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"DELETE FROM \"Reservation\" WHERE \"ID_reservation\"={id}";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static Boolean hasReservation(int id,DateTime checkin, DateTime checkout)
        {
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT COUNT(*) FROM getallByDate("+id+",'" + checkin.Year + "-" + checkin.Month + "-" + checkin.Day +"','" + checkout.Year + "-" + checkout.Month + "-" + checkout.Day + "')";
            NpgsqlDataReader reader = command.ExecuteReader();
            Boolean hasReservation = false;
            while (reader.Read())
            {
                if ((long)reader["count"] > 0)
                    hasReservation = true;
            }


            reader.Close();
            connection.Close();

            return hasReservation;
        }

        public static long NoMorePpl(int id, DateTime checkin, DateTime checkout)
        {
            List<Room> rooms = RoomRepo.getall();
            Room room=new Room();
            foreach (Room room1 in rooms)
            {
                if (room1.id == id)
                {
                    room = room1;
                    break;
                }
            }

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT COUNT(*) FROM \"Reservation\" WHERE \"Room_id\"=" + id + " AND \"Check_in\"='" + checkin.Year + "-" + checkin.Month + "-" + checkin.Day + "' AND \"Check_out\"='" + checkout.Year + "-" + checkout.Month + "-" + checkout.Day + "'"; NpgsqlDataReader reader = command.ExecuteReader();
            long count = 0;
            while (reader.Read())
            {
                count = (long)reader["count"];
            }


            reader.Close();
            connection.Close();

            return count;
        }

        public static List<Reservation> getall()
        {
            List<Room> rooms = RoomRepo.getall();
            List<Client> clients = ClientRepo.getall();
            List<Profile> profiles = ProfileRepo.getall();

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM \"Reservation\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            var result = new List<Reservation>();
            while (reader.Read())
            {
                foreach (Client client in clients)
                {
                    if (client.id == (int)reader["Client_id"])
                        foreach (Room room in rooms)
                        {
                            if (room.id == (int)reader["Room_id"])
                                foreach (Profile profile in profiles)
                                {
                                    if (profile.id == (int)reader["Profile_id"])
                                        result.Add(new Reservation(
                                        id: (int)reader["ID_reservation"],
                                        client: client,
                                        room: room,
                                        checkIn: DateOnly.FromDateTime((DateTime)reader["Check_in"]),
                                        checkOut: DateOnly.FromDateTime((DateTime)reader["Check_out"]),
                                        profile: profile,
                                        price: (Decimal)reader["Price"]));
                                }
                        }
                }
            }


            reader.Close();
            connection.Close();

            return result;
        }

        public static DataTable getTableById(int id, DateTime checkin, DateTime checkout)
        {
            DataTable table = new DataTable();

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT \"ID_reservation\" as \"ID на резервацията\", \"Client\".\"Fullname\" as \"Клиент\", \"Client\".\"egn\" as \"ЕГН\", \"Check_in\" as \"Дата на настаняване\", \"Check_out\" as \"Дата на напускане\", \"Price\" as \"Цена\", \"Profile\".\"Username\" as \"Рецепционист\"" +
                $" FROM \"Reservation\" JOIN \"Client\" on \"Client\".\"ID_client\"=\"Reservation\".\"Client_id\" JOIN \"Profile\" on \"Profile\".\"ID_profile\"=\"Reservation\".\"Profile_id\" WHERE \"Room_id\"="+id+ " AND \"Check_in\"='" + checkin.Year + "-" + checkin.Month + "-" + checkin.Day + "' AND \"Check_out\"='" + checkout.Year + "-" + checkout.Month + "-" + checkout.Day + "'";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }

        public static DataTable getTable()
        {
            DataTable table = new DataTable();

            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT \"Room_id\" as \"Стая №\" , \"Type\".\"Type\" as \"Вид\" ,\"Room\".\"Bathroom\" as \"Баня\" , \"Client\".\"Fullname\" as \"Клиент\", \"Client\".\"egn\" as \"ЕГН\", \"Check_in\" as \"Дата на настаняване\", \"Check_out\" as \"Дата на напускане\", \"Reservation\".\"Price\" as \"Цена\", \"Profile\".\"Username\" as \"Рецепционист\"" +
                $" FROM \"Reservation\" JOIN \"Client\" on \"Client\".\"ID_client\"=\"Reservation\".\"Client_id\" JOIN \"Profile\" on \"Profile\".\"ID_profile\"=\"Reservation\".\"Profile_id\" " +
                $"JOIN \"Room\" on \"Room\".\"ID_room\"=\"Reservation\".\"Room_id\" JOIN \"Type\" on \"Type\".\"ID_type\"=\"Room\".\"Type_id\" ORDER BY \"ID_reservation\"";
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
            String column="";
            switch(col){
                case "Стая №":
                    column = "CAST(\"Room_id\" AS TEXT)";
                    break;
                case "Вид":
                    column = "\"Type\".\"Type\"";
                    break;
                case "Баня":
                    column = "CAST(\"Room\".\"Bathroom\" AS TEXT)";
                    if (search == "има" || search == "Има" || search == "да" || search == "Да" || search == "с" || search == "С" || search == "със" || search == "Със")
                        search = "true";
                    else if (search == "няма" || search == "Няма" || search == "не" || search == "Не" || search == "без" || search == "Без")
                        search = "false";
                    break;
                case "Клиент":
                    column = "\"Client\".\"Fullname\"";
                    break;
                case "ЕГН":
                    column = "\"Client\".\"egn\"";
                    break;
                case "Дата на настаняване":
                    column = "\"Check_in\"";
                    break;
                case "Дата на напускане":
                    column = "\"Check_out\"";
                    break;
                case "Цена":
                    column = "CAST(\"Reservation\".\"Price\" AS TEXT)";
                    break;
                case "Рецепционист":
                    column = "\"Profile\".\"Username\"";
                    break;
            }

            command.CommandText = $"SELECT \"Room_id\" as \"Стая №\" , \"Type\".\"Type\" as \"Вид\" ,\"Room\".\"Bathroom\" as \"Баня\" , \"Client\".\"Fullname\" as \"Клиент\", \"Client\".\"egn\" as \"ЕГН\", \"Check_in\" as \"Дата на настаняване\", \"Check_out\" as \"Дата на напускане\", \"Reservation\".\"Price\" as \"Цена\", \"Profile\".\"Username\" as \"Рецепционист\"" +
                $" FROM \"Reservation\" JOIN \"Client\" on \"Client\".\"ID_client\"=\"Reservation\".\"Client_id\" JOIN \"Profile\" on \"Profile\".\"ID_profile\"=\"Reservation\".\"Profile_id\" " +
                $"JOIN \"Room\" on \"Room\".\"ID_room\"=\"Reservation\".\"Room_id\" JOIN \"Type\" on \"Type\".\"ID_type\"=\"Room\".\"Type_id\" WHERE "+column+" LiKE '%"+search+"%' ORDER BY \"ID_reservation\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            reader.Close();
            connection.Close();

            return table;
        }

        public static void update(Reservation reservation)
        {
            List<Reservation> reservations = getall();
            NpgsqlConnection connection = Connection.open();
            command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;

            Boolean flag = true;

            foreach (Reservation r in reservations)
            {
                if (r.id == reservation.id)
                {
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Client_id\"=" + reservation.client.id + " WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Room_id\"=" + reservation.room.id + " WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Profile_id\"=" + reservation.profile.id + " WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Price\"='" + reservation.price + "' WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Check_in\"='" + reservation.checkIn.Year + "-" + reservation.checkIn.Month+"-" + reservation.checkIn.Day + "' WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"UPDATE \"Reservation\" SET \"Check_out\"='" + reservation.checkOut.Year + "-" + reservation.checkOut.Month + "-" + reservation.checkOut.Day + "' WHERE \"ID_reservation\"=" + reservation.id;
                    command.ExecuteNonQuery();

                    flag = false;
                    connection.Close();
                }
            }

            if (flag)
            {
                save(reservation);
            }


            connection.Close();

        }
    }
}
