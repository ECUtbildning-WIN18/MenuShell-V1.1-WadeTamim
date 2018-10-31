
using System;
using MenuShell_v1._1.View;

namespace MenuShell_v1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var login = new LoginView("Login");
            login.Display();

            Console.ReadKey();
        }
    }
}
