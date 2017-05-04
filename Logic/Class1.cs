using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logic
{
    public class Class1
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source = ealdb1.eal.local;
                 Database = EJL63_DB;
                 User ID = ejl63_usr;
                 Password = Baz1nga63"
                );
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Area, Category, Description, ProviderID   FROM [EJL63_DB].[db_owner].[Items]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}. {1} {2} {3} {4} {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
            conn.Close();
            Console.ReadKey();
        }
    }
}
