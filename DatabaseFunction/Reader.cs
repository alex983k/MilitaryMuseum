using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseFunction
{
    public class Reader
    {
        public static List<string> Reading(string text, SqlConnection conn)
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Area, Category, Description, ProviderID   FROM [EJL63_DB].[db_owner].[Items]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add("{0}. {1} {2} {3} {4} {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
            
            return result;
        }
    }
}
