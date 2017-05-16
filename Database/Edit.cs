using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    public class Edit
    {
        public static void DeleteItem(int id, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Delete_Item", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("ID", id));
            cmd.ExecuteNonQuery();
        }
        public static void DeleteProvider(int id, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Delete_Provider", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("ID", id));
            cmd.ExecuteNonQuery();
        }
        public static void InsertItem(Item i, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Insert_Item", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("ID", i.ID));
            cmd.Parameters.Add(new SqlParameter("Name", i.Name));
            cmd.Parameters.Add(new SqlParameter("Area", i.Area));
            cmd.Parameters.Add(new SqlParameter("Category", i.Category));
            cmd.Parameters.Add(new SqlParameter("Description", i.Description));
            cmd.Parameters.Add(new SqlParameter("IDLocation", i.IDLocation));
            cmd.Parameters.Add(new SqlParameter("ProviderID", i.ProviderID));
            cmd.ExecuteNonQuery();
        }
        public static void InsertProvider(Provider p, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Insert_Provider", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("Name", p.Name));
            cmd.Parameters.Add(new SqlParameter("Email", p.Email));
            cmd.Parameters.Add(new SqlParameter("Phone", p.Phone));
            cmd.ExecuteNonQuery();
        }
        public static void UpdateItem(Item i, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Update_Item", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("ID", i.ID));
            cmd.Parameters.Add(new SqlParameter("Name", i.Name));
            cmd.Parameters.Add(new SqlParameter("Area", i.Area));
            cmd.Parameters.Add(new SqlParameter("Category", i.Category));
            cmd.Parameters.Add(new SqlParameter("Description", i.Description));
            cmd.Parameters.Add(new SqlParameter("IDLocation", i.IDLocation));
            cmd.Parameters.Add(new SqlParameter("ProviderID", i.ProviderID));
            cmd.ExecuteNonQuery();
        }
        public static void UpdateProvider(Provider p, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Update_Provider", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("ID", p.ID));
            cmd.Parameters.Add(new SqlParameter("Name", p.Name));
            cmd.Parameters.Add(new SqlParameter("Email", p.Email));
            cmd.Parameters.Add(new SqlParameter("Phone", p.Phone));
            cmd.ExecuteNonQuery();
        }
    }
}
