using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_v1._1.Domain.Services
{
    interface IUserLoader
    {
        Dictionary<string, User> LoadUsers();
    }
}
