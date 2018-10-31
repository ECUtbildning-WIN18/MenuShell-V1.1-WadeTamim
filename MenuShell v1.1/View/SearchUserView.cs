using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MenuShell_v1._1.Domain;
using MenuShell_v1._1.Domain.Services;

namespace MenuShell_v1._1.View
{
    class SearchUserView : BaseView
    {
        public SearchUserView(string title) : base(title)
        {
        }

        public override void Display()
        {
            Console.ResetColor();
            Console.Clear();
            Console.Write("Search by username:");
            string username = Console.ReadLine();

            var search = new SearchUser();
            var searchResult = new Dictionary<string,User>();

            searchResult = search.Search(username);

            if (!searchResult.Any())
            {
                Console.WriteLine($"\nNo users found matching the search term {username}.");
                Thread.Sleep(2000);
                var manage = new ManageView("Manage");
                manage.Display();
            }
            else
            {
                int i = 1;
                foreach (var name in searchResult.Keys)
                {
                    Console.WriteLine(i+". "+name);
                    i++;
                }
            }

            Console.WriteLine("\n(D)elete");
            Console.WriteLine("Any other key you will be directed back to Manage View ...");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D:
                    var delete = new DeleteView("Delete");
                    delete.DeleteDisplay(searchResult);
                    break;

                default:
                    var manage = new ManageView("Manage");
                    manage.Display();
                    break;
            }
        }
    }
}
