using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DataAccess
    {
        static SqlConnection conn;

        static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString=@"Data Source=DESKTOP-PHFRTLE\SQLEXPRESS; database= LibraryManagement; Integrated Security=True";

               // conn = new SqlConnection(@"Data Source=DESKTOP-PHFRTLE\SQLEXPRESS; Initial Catalog=simple;Integrated Security=True");
               // conn = new SqlConnection(Contacto.Data.Properties.Settings.Default.personDbConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }
    }
}
