using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace PetRegistry
{
    static class AuthorizationService
    {
        public static DataTable GetPassword(string login)
        {
            string query = "SELECT UserPassword From Users Where UserLogin='" + login+ "'";
          
            DataTable data = Database.ExecuteQuery(query);
            return data; 
        }
    }
}
