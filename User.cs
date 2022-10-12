using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_Frontend
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string bio { get; set; }

        public User(string u, string p, string b)
        {
            Username = u;
            Password = p;
            bio = b;
        }
    }
}
