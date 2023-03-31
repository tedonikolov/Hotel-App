using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Entity
{
    internal class Room
    {
        public int id { get; set; }
        public Boolean bathroom { get; set; }
        public Type type { get; set; }

        public Room() { }

        public Room(int id, bool bathroom, Type type)
        {
            this.id = id;
            this.bathroom = bathroom;
            this.type = type;
        }
    }
}
