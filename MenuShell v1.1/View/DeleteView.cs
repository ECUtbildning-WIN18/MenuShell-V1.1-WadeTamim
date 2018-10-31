using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell_v1._1.Domain;
using MenuShell_v1._1.Domain.Services;

namespace MenuShell_v1._1.View 
{
    class DeleteView : BaseView
    {
        public DeleteView(string title) : base(title)
        {
        }

        public void DeleteDisplay(Dictionary<string,User> users)
        {
            int i = 1;
            Console.Clear();
            foreach (var name in users.Keys)
            {
                Console.WriteLine(i + ". " + name);
                i++;
            }

            Console.Write("\nDelete > ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nDelete user {userName}? (Y)es (N)o");
            Console.WriteLine("\nPress Escape to return to Manage View ...");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Y:
                    var delete = new DeleteUser();
                    delete.Delete(userName);
                    break;

                case ConsoleKey.N:
                    DeleteDisplay(users);
                    break;

                case ConsoleKey.Escape:
                    var manage = new ManageView("Manage");
                    manage.Display();
                    break;

                default:

                    break;
            }
        }
    }
}
