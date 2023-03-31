using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DataLayer.Entity
{
    public class Role
    {
        public int id {get;set;}
        public string role { get;set;}

        public Role(string role) {
            this.role = role;
        }

        public Role(int id,string role)
        {
            this.id = id;
            this.role = role;
        }
    }
}
