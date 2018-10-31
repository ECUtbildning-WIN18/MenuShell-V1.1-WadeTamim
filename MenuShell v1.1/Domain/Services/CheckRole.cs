using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell_v1._1.View;

namespace MenuShell_v1._1.Domain.Services
{
    class CheckRole
    {
        public void Check(User user)
        {
            if (user.UserRole == Role.Administrator)
            {
                AdministratorView admin = new AdministratorView("Admin View");
                admin.Display();
            }
            else if (user.UserRole == Role.User)
            {
                UserView userView = new UserView("Welcome User");
                userView.Display();
            }
        }
    }
}
