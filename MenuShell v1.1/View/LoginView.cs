using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MenuShell_v1._1.Domain.Services;

namespace MenuShell_v1._1.View
{
    class LoginView : BaseView
    {
        public LoginView(string title) : base(title)
        {

        }
        public override void Display()
        {
            Console.ResetColor();
            Console.Clear();

            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");
            Console.WriteLine("\nPress Esc to exit.");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.N:
                    Console.Clear();
                    Display();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            var authenticationService = new AuthenticationService();

            var user = authenticationService.Authenticate(username, password);

            if (user != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nSuccessfully logged in!");
                Console.WriteLine($"\n\n\nRole: {user.UserRole}");
                Thread.Sleep(1500);

                var check = new CheckRole();
                check.Check(user);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nLogin failed. Please try again.");
                Thread.Sleep(1500);
                Display();
            }
        }
    }
}
