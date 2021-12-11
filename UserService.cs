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
            string query = @"SELECT Users.UserLogin, Organizations.OrgName From Users 
inner join Organizations on Users.OrgId = Organizations.IDOrganization
Where Users.UserLogin = '" + login + "'";
            DataTable dataOrg = Database.ExecuteQuery(query); //проверяем есть ли организация

            if(dataOrg.Rows.Count == 0) //если нет значит пользователь
            {
                string queryUser = @"SELECT Users.UserLogin, Users.UserName, Roles.RoleName, Users.Country, Users.Adress, Users.Phone, Users.Email From Users
inner join Roles on Users.RoleId = Roles.IDRole
Where Users.UserLogin ='" + login + "'";

                return Database.ExecuteQuery(queryUser);
            }
            else //если есть значит организация
            {
                string queryOrg = @"SELECT Users.UserLogin, Users.UserName, Roles.RoleName, Users.Country, Users.Adress, Users.Phone, Users.Email, Organizations.OrgName From Users 
inner join Roles on Users.RoleId = Roles.IDRole 
inner join Organizations on Users.OrgId = Organizations.IDOrganization 
Where Users.UserLogin='" + login + "'";

                return Database.ExecuteQuery(queryOrg);
            }
           
        }
    }
}
