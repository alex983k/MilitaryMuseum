using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class LoginValidation
    {
        public bool Login(string username, string password)
        {
            bool result = false;
            if (username == "admin"&& password == "pass")
            {
                result = true;
            }
            return result;
        }
    }
}
