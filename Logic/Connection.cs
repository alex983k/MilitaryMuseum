using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Connection
    {
        public static bool Login(string username, string password, List<string> loginData)
        {
            bool result = false;
            if (username == loginData[0] && password == loginData[1])
            {
                result = true;
            }
            return result;
        }
    }
}
