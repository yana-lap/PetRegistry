using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PetRegistry
{
    static class Database
    {
        static string connectionString = "Data Source=DESKTOP-B6GV2B9\\SQLEXPRESS;Initial Catalog=VetDB;Integrated Security=True";
        static SqlConnection connect = new SqlConnection(connectionString);
        public static void OpenConnection()
        {
        }

        public static DataTable ExecuteQuery(string query)
        {

            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            SqlDataReader itogi = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(itogi);

            connect.Close();
            return dt;
        }
        public static void CloseConnection()
        {
        }
    }
}
