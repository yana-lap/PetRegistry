using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    static class OwnerService
    {
        public static DataTable GetOwnersUserRegistry(Dictionary<string, List<string>> filtersNames, Dictionary<string, List<string>> sortNames)
        {
            string query = @"SELECT Users.IDUser, Users.Username, Users.Country, Users.Adress,  Users.Phone, Users.Email,
                             Count(Pets.OwnerUser) as PetsCount, dbo.GetCatDogCount(1,Users.IDUser,1) as CatCount, dbo.GetCatDogCount(1,Users.IDUser,2) as DogCount
                             FROM Users 
                             INNER JOIN Pets ON Users.IDUser = Pets.OwnerUser 
                             Group By Users.IDUser, Users.Username, Users.Country, Users.Adress,  Users.Phone, Users.Email";

            if (filtersNames != null)
            {
                List<string> filterQueries = new List<string>();

                foreach (var key in filtersNames.Keys)
                {
                    string filter = "(";

                    if (key == "Users.Country")
                    {
                        for (int i = 0; i < filtersNames[key].Count; i++)
                        {
                            filter += key + " = '" + filtersNames[key][i] + "'";

                            if (i < filtersNames[key].Count - 1)  filter += " or ";
                        }
                        filter += ")";
                    }
                    else
                    {
                        filter += key + " between " + filtersNames[key][0] + " and " + filtersNames[key][1] + ")";
                    }

                    filterQueries.Add(filter);
                }

                query += " having ";
                for (int i = 0; i < filterQueries.Count; i++)
                {
                    query += filterQueries[i];

                    if (i != filterQueries.Count - 1) query += " and ";
                }
            }
            
            DataTable data = Database.ExecuteQuery(query);
            return data;
        }

        public static DataTable GetOwnersOrgRegistry(Dictionary<string, List<string>> filtersNames, Dictionary<string, List<string>> sortNames)
        {
            string query = @"SELECT Organizations.IDOrganization, Organizations.OrgName, Organizations.INN,
                             Organizations.KPP, Organizations.Country, Organizations.Adress,  Organizations.Phone, Organizations.Email, 
                             Count(Pets.OwnerCompany) as PetsCount, 
                             dbo.GetCatDogCount(2,Organizations.IDOrganization,1) as CatCount, dbo.GetCatDogCount(2,Organizations.IDOrganization,2) as DogCount
                             FROM Organizations 
                             INNER JOIN Pets ON Organizations.IDOrganization = Pets.OwnerCompany
                             Group By Organizations.IDOrganization, Organizations.OrgName, Organizations.INN, Organizations.KPP,
                             Organizations.Country, Organizations.Adress,  Organizations.Phone, Organizations.Email";

            if (filtersNames != null)
            {
                List<string> filterQueries = new List<string>();

                foreach (var key in filtersNames.Keys)
                {
                    string filter = "(";

                    if (key == "Organizations.Country")
                    {
                        for (int i = 0; i < filtersNames[key].Count; i++)
                        {
                            filter += key + " = '" + filtersNames[key][i] + "'";

                            if (i < filtersNames[key].Count - 1) filter += " or ";
                        }
                        filter += ")";
                    }
                    else
                    {
                        filter += key + " between " + filtersNames[key][0] + " and " + filtersNames[key][1] + ")";
                    }

                    filterQueries.Add(filter);
                }

                query += " having ";
                for (int i = 0; i < filterQueries.Count; i++)
                {
                    query += filterQueries[i];

                    if (i != filterQueries.Count - 1) query += " and ";
                }
            }

            DataTable data = Database.ExecuteQuery(query);
            return data;
        }
    }
}
