using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Database
{
    public class Connection
    {
        public static SqlConnection Connect()
        {
            //string text = File.ReadAllText(@"Database.txt");
            //Console.WriteLine(text);
            //SqlConnection conn = new SqlConnection(text);
            SqlConnection conn = new SqlConnection(
            @"Data Source = ealdb1.eal.local;
            Database = EJL63_DB;
            User ID = ejl63_usr;
            Password = Baz1nga63"
            );
            return conn;
        }
    }
}
