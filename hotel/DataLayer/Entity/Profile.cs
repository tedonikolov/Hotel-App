using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Entity
{
    public class Profile
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Role role { get; set; }
        
        public Profile() { }

        public Profile(int id, string username, string password, Role role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
