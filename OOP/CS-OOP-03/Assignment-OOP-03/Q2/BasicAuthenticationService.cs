using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        

        public bool AuthenticateUser(string UserName, string Password)
        {
            if (UserName == this.UserName && Password == this.Password)
            {
                return true;
            }
            else return false;
        }


        public bool AuthorizeUser(string UserName, string Role)
        {
           if(UserName == this.UserName && Role == "Admin")
            {
                return true;
            }
           return false;
        }
    }
}
