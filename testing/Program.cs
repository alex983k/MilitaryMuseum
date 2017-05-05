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
            string text = "0";
            SqlConnection conn = new SqlConnection
                (@"Data Source = ealdb1.eal.local;
                 Database = EJL63_DB;
                 User ID = ejl63_usr;
                 Password = Baz1nga63"
                );
            conn.Open();
            DatabaseFunction.Reader.Reading(text, conn);
            conn.Close();
            Console.ReadKey();
        }
    }
}
