using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer
{
    internal class Type
    {
        public int id { get; set; }
        public string type { get; set; }
        public Decimal price { get; set; }
        public int people { get; set; }

        public Type(string type, Decimal price) { this.type = type; this.price = price; }
        public Type(int id, string type, Decimal price, int people)
        {
            this.id = id;
            this.type = type;
            this.price = price;
            this.people = people;
        }
    }
}
