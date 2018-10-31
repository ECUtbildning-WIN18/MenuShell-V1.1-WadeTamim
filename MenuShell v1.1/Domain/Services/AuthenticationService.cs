using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_v1._1.Domain.Services
{
    class AuthenticationService
    {
        private readonly IUserLoader _userLoader;

        public AuthenticationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            var users = _userLoader.LoadUsers();
            
            return users.Values.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
