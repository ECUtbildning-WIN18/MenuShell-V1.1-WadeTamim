using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell_v1._1.Domain.Services;

namespace MenuShell_v1._1.View
{
    class AddUserView : BaseView
    {
        public AddUserView(string title) : base(title)
        {
        }

        public override void Display()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("# Add user");

            Console.Write("\nUsername:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
            Console.Write("Role:");
            string role = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");
            Console.WriteLine("\nPress Esc to return to ManageView");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.N:
                    Console.Clear();
                    Display();
                    break;
                case ConsoleKey.Escape:
                    var manage = new ManageView("Manage");
                    manage.Display();
                    break;
                default:
                    break;
            }

            var user = new AddUser();
            user.AddNewUser(username, password, role);
        }
    }
}
