using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PetRegistry
{
    class Authorization
    {
        public bool Login(string login, string password)
        {
            string passwordFromServer = "";
            DataTable data = AuthorizationService.GetPassword(login);
            if(data.Rows.Count !=0) passwordFromServer = data.Rows[0][0].ToString();
            if (CheckAuthorization(password, passwordFromServer))
            {
                User user = new User();
                user.LoadUserInfo(login);
                return true;
            }
            else return false;
        }

        public bool CheckAuthorization(string password, string passwordFromServer)
        {
            return password == passwordFromServer;
        }
    }
}
