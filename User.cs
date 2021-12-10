using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PetRegistry
{
    class User
    {
        public string FIO;
        public string Login;
        //public string Password;
        public string Phone;
        public string Address;
        public string Country;
        public string Email;
        public Role Role;
        public Organization Organization;


        public void LoadUserInfo(string login)
        {
            DataTable data = UserService.GetUserInfo(login);
            if (data.Rows.Count != 0)
            {
                FIO = data.Rows[0][1].ToString();
                Login = data.Rows[0][4].ToString();
                //Password = data.Rows[0][5].ToString();
                Phone = data.Rows[0][6].ToString();
                Address = data.Rows[0][7].ToString();
                Country = data.Rows[0][8].ToString();
                Email = data.Rows[0][9].ToString();
            }

        }
    }
}
