using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary;
using Database;
using Login;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {

            LoginValidation validator = new LoginValidation();
            SqlConnection con = Database.Connection.Connect();
            con.Open();
            bool c= validator.Login("admin", "1234");
            int i = 2;
            Provider p = new Provider(0, "Alex", "Fake emauil", "355635");
            Edit.InsertProvider(p, con);
                Console.WriteLine(i);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
