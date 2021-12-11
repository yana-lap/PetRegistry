using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PetRegistry
{
    public class User
    {
        public string FIO;
        public string Login;
        public string Phone;
        public string Address;
        public string Country;
        public string Email;
        public string Role;
        public string Organization;

        public void LoadUserInfo(string login)
        {
            DataTable data = UserService.GetUserInfo(login);
            if (data.Rows.Count != 0)
            {
                Login = data.Rows[0][0].ToString();
                FIO = data.Rows[0][1].ToString();
                Role = data.Rows[0][2].ToString();
                Country = data.Rows[0][3].ToString();
                Address = data.Rows[0][4].ToString();
                Phone = data.Rows[0][5].ToString();
                Email = data.Rows[0][6].ToString();
                if(data.Columns.Count ==8) Organization = data.Rows[0][7].ToString();
            }
        }
    }
}
