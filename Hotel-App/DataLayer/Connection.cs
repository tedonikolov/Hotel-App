using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer
{
    internal class Connection
    {
        private static NpgsqlConnection connection { get; set; }
        private static Connection connectioninit;

        private Connection()
        {
            connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=hotel;User id=postgres;Password=exit");
        }

        public static NpgsqlConnection open() { 
            if(connection == null)
            {
                connectioninit = new Connection();
            }
            if(connection.State!=ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

    }
}
