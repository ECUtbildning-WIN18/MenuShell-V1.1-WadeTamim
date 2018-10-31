using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_v1._1.Domain.Services
{
    class SearchUser
    {
        private readonly IUserLoader _userLoader;

        public SearchUser()
        {
            _userLoader = new UserLoader();
        }
        public Dictionary<string,User> Search(string username)
        {
            var backUsers= new Dictionary<string,User>();
            var users = _userLoader.LoadUsers();

            foreach (var name in users.Values)
            {
                if (name.Username.Contains(username))
                {
                   backUsers.Add(name.Username,new User(name.Username,name.Password,name.UserRole));
                }
            }

            return backUsers;
        }
    }
}
