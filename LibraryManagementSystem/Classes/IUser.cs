using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    interface IUser
    {
         string Username { get; set; }
         string Password { get; set; }
         string UserType { get; set; }

        void Login();
    }
}
