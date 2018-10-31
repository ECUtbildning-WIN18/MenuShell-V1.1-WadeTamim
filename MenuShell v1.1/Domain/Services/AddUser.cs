using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using MenuShell_v1._1.View;

namespace MenuShell_v1._1.Domain.Services
{
    class AddUser
    {
        private readonly IUserLoader _userLoader;

        public AddUser()
        {
            _userLoader = new UserLoader();
        }
        public void AddNewUser(string username, string password, string role)
        {
            var users = _userLoader.LoadUsers();

            if (role == "Administrator" || role == "administrator")
            {
                users.Add(username, new User(username, password, Role.Administrator));
            }
            else if (role == "User" || role == "user")
            {
                users.Add(username, new User(username, password, Role.User));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou have entered an invalid role!");
                Console.WriteLine("\nWe have Administrator or User at the moment");
                var add = new AddUserView("AddUser");
                Thread.Sleep(2000);
                add.Display();
            }

            var doc = XDocument.Load("Users.xml");

            XElement root = new XElement("User");

            root.Add(new XAttribute("username", username));
            root.Add(new XAttribute("password", password));
            root.Add(new XAttribute("role", role));

            doc.Element("Users").Add(root);
            doc.Save("Users.xml");

            var admin = new AdministratorView("Admin");
            admin.Display();
        }

    }
}
