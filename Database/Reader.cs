using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Database
{
    public class Reader
    {
        public static List<Item> ReadItems(SqlConnection conn)
        {
            List<Item> result = new List<Item>();
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Area, Category, Description, IDLocation, ProviderID   FROM [EJL63_DB].[db_owner].[Items]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Item i = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6));
                result.Add(i);
            }
            reader.Close();
            return result;
        }
        public static List<Provider> ReadProviders(SqlConnection conn)
        {
            List<Provider> result = new List<Provider>();
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Email, Phone   FROM [EJL63_DB].[db_owner].[Providers]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Provider i = new Provider(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                result.Add(i);
            }
            reader.Close();
            return result;
        }
        public static List<string> ReadLogin(SqlConnection conn)
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT Username, Password   FROM [EJL63_DB].[db_owner].[Login]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
                result.Add(reader.GetString(1));
            }
            reader.Close();
            return result;
        }
    }
}
