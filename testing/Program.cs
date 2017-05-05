using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = Database.Connection.Connect();
            conn.Open();
            Connection.Connection.Login("admin", "1234", Database.Reader.ReadLogin(conn));
            int i = 2;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
