using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Entity
{
    internal class Client
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string egn { get; set; }


        public Client() { }
        public Client(int id, string fullname, string phoneNumber, string email, string egn)
        {
            this.id = id;
            this.fullname = fullname;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.egn = egn;
        }
    }
}
