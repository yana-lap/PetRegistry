using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    static class OwnerService
    {
        public static DataTable GetOwnersUserRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {
            string query = @"SELECT Users.IDUser, Users.Username, Users.Country, Users.Adress,  Users.Phone, Users.Email, Count(Pets.OwnerUser) as PetsCount
 FROM Users 
INNER JOIN Pets ON Users.IDUser = Pets.OwnerUser 
WHERE Pets.OwnerType='1'
Group By Users.IDUser, Users.Username, Users.Country, Users.Adress,  Users.Phone, Users.Email";

            DataTable data = Database.ExecuteQuery(query);
            return data;
        }

        public static DataTable GetOwnersOrgRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {
            string query = @"SELECT Organizations.IDOrganization, Organizations.OrgName, Organizations.INN, Organizations.KPP, Organizations.Country, Organizations.Adress,  Organizations.Phone, Organizations.Email, Count(Pets.OwnerCompany) as PetsCount
 FROM Organizations 
INNER JOIN Pets ON Organizations.IDOrganization = Pets.OwnerCompany 
WHERE Pets.OwnerType='2'
Group By Organizations.IDOrganization, Organizations.OrgName, Organizations.INN, Organizations.KPP, Organizations.Country, Organizations.Adress,  Organizations.Phone, Organizations.Email";
            DataTable data = Database.ExecuteQuery(query);
            return data;
        }
    }
}
