using System;
using System.Xml.Linq;
using MenuShell_v1._1.View;

namespace MenuShell_v1._1.Domain.Services
{
    class DeleteUser
    {
        private readonly IUserLoader _userLoader;

        public DeleteUser()
        {
            _userLoader = new UserLoader();
        }

        public void Delete (string userName)
        {
            var users = _userLoader.LoadUsers();

            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                if (userName == element.Attribute("username").Value)
                {
                    element.Remove();
                    doc.Save("Users.xml");
                }
            }

            Console.WriteLine("\nDone ...");
            Console.WriteLine("\n\nPress Any key to return to Manage View");
            Console.ReadKey();
            var manage = new ManageView("Manage");
            manage.Display();
        }
    }
}
