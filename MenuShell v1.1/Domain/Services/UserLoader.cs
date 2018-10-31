using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuShell_v1._1.Domain.Services
{
    class UserLoader : IUserLoader
    {
        public Dictionary<string, User> LoadUsers()
        {
            var users = new Dictionary<string, User>();

            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;
                
                Enum.TryParse(role, out Role roleResult );

                if (role == "Administrator"||role== "administrator")
                {
                    users.Add(username, new User(username, password,Role.Administrator));
                }else if (role == "user" || role == "User")
                {
                    users.Add(username, new User(username, password, Role.User));
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is fail role in Loaded XML file!");
                }
            }

            users.Add("admin", (new User("admin", "secret", Role.Administrator)));

            return users;
        }
    }
}
