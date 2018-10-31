using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_v1._1.Domain
{
    class User
    {
        public string Username { get; }
        public string Password { get; }
        public Role UserRole { get; }

        public User(string username, string password, Role userRole)
        {
            Username = username;
            Password = password;
            UserRole = userRole;
        }
    }
}
