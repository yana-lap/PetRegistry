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
            string query = "SELECT Users.UserLogin, Users.UserName, Roles.RoleName, Organizations.OrgName, Users.Country, Users.Adress, Users.Phone, Users.Email From Users" +
                " inner join Roles on Users.RoleId = Roles.IDRole" +
                " inner join Organizations on Users.OrgId = Organizations.IDOrganization" +
                " Where Users.UserLogin='" + login + "'";
            DataTable data = Database.ExecuteQuery(query);

            return data;
        }
    }
}
