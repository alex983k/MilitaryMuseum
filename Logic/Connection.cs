using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Connection
    {
        public static bool Login(string username, string password)
        {
            bool result = false;
            if (username == "admin" && password == "1234")
            {
                result = true;
            }
            return result;
        }
    }
}
