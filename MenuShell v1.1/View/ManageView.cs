using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuShell_v1._1.View
{
    class ManageView : BaseView
    {
        public ManageView(string title) : base(title)
        {
        }

        public override void Display()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Search user");
            Console.WriteLine("\n\nPress Esc to return to Admin Menu");
            Console.Write("\n>");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddUserView add = new AddUserView("Add User");
                    add.Display();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchUserView search = new SearchUserView("Search User");
                    search.Display();
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
