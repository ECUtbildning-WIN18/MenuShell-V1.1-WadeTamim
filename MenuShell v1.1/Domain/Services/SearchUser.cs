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
        public List<User> Search(string username)
        {
            var backUsers= new List<string>();
            var users = _userLoader.LoadUsers();

            foreach (var name in users.Keys)
            {
                if (name.Contains(username))
                {
                    backUsers.Add(users.ToString());
                }
            }

            return null;
        }
        //contain
    }
}
