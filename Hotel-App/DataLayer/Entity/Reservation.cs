using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Entity
{
    internal class Reservation
    {
        public int id { get; set; }
        public Client client { get; set; }
        public Room room { get; set; }
        public DateOnly checkIn { get; set; }
        public DateOnly checkOut { get; set; }
        public Profile profile { get; set; }

        public Reservation()
        {

        }
        public Reservation(int id, Client client, Room room, DateOnly checkIn, DateOnly checkOut, Profile profile)
        {
            this.id = id;
            this.client = client;
            this.room = room;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.profile = profile;
        }
    }
}
