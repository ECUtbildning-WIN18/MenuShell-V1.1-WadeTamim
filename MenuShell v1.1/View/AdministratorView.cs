using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuShell_v1._1.View
{
    class AdministratorView : BaseView
    {
        public AdministratorView(string title) : base(title)
        {
        }

        public override void Display()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Exit");
            Console.WriteLine("\n\nPress Esc To return to Login Menu");
            Console.Write("\n>");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ManageView manage = new ManageView(" Manage users ");
                    manage.Display();

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Escape:
                    LoginView login = new LoginView("Login");
                    login.Display();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe options are 1 or 2 .");
                    Thread.Sleep(1500);
                    Display();
                    break;
            }
        }
    }
}
