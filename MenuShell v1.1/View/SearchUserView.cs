using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            search.Search(username);
        }
    }
}
