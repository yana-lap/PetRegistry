using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace PetRegistry
{
    static class UserService
    {
        public static DataTable GetUserInfo(string login)
        {
            string query = "SELECT * From Users Where UserLogin='" + login + "'";
            DataTable data = Database.ExecuteQuery(query);
            return data;
        }
    }
}
