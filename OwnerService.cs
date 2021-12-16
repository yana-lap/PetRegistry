using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    static class OwnerService
    {
        public static DataTable GetOwnersUserRegistry(Dictionary<string, List<string>> filtersNames)
        {
            string query = @"SELECT Users.IDUser, Users.Username, Users.Country, Users.Adress,  Users.Phone, Users.Email,
dbo.GetPetCount(1,Users.IDUser) as PetsCount, dbo.GetCatDogCount(1,Users.IDUser,1) as CatCount, dbo.GetCatDogCount(1,Users.IDUser,2) as DogCount
FROM Users 
Where dbo.GetPetCount(1,Users.IDUser) > 0";

            if (filtersNames.Keys.Count != 0)
            {
                query += " and ";

                List<string> filterQuery = new List<string>();

                foreach (var key in filtersNames.Keys)
                {
                    string filterKey = "(";
                    if (key == "petsNumberFrom")
                    {
                        filterKey += "dbo.GetPetCount(1,Users.IDUser) > '" + filtersNames["petsNumberFrom"][0] + "'";
                    }
                    if (key == "petsNumberTo")
                    {
                        filterKey += "dbo.GetPetCount(1,Users.IDUser) < '" + filtersNames["petsNumberTo"][0] + "'";
                    }
                    if (key == "catsNumberFrom")
                    {
                        filterKey += "dbo.GetCatDogCount(1,Users.IDUser,1) > '" + filtersNames["catsNumberFrom"][0] + "'";
                    }
                    if (key == "catsNumberTo")
                    {
                        filterKey += "dbo.GetCatDogCount(1,Users.IDUser,1) < '" + filtersNames["catsNumberTo"][0] + "'";
                    }
                    if (key == "dogsNumberFrom")
                    {
                        filterKey += "dbo.GetCatDogCount(1,Users.IDUser,2) > '" + filtersNames["dogsNumberFrom"][0] + "'";
                    }
                    if (key == "dogsNumberTo")
                    {
                        filterKey += "dbo.GetCatDogCount(1,Users.IDUser,2) < '" + filtersNames["dogsNumberTo"][0] + "'";
                    }
                    if (key == "Users.Country")
                    {
                        for (int i = 0; i < filtersNames[key].Count; i++)
                        {
                            filterKey += key + " = '" + filtersNames[key][i] + "'";

                            if (i != filtersNames[key].Count - 1) filterKey += " or ";
                        }
                    }

                    filterKey += ")";
                    filterQuery.Add(filterKey);
                }

                for (int i = 0; i < filterQuery.Count; i++)
                {
                    query += filterQuery[i];

                    if (i == filterQuery.Count - 1) query += ";";
                    else query += " and ";
                }
            }
            
            DataTable data = Database.ExecuteQuery(query);
            return data;
        }

        public static DataTable GetOwnersOrgRegistry(Dictionary<string, List<string>> filtersNames)
        {
            string query = @"SELECT Organizations.IDOrganization, Organizations.OrgName, Organizations.INN,
Organizations.KPP, Organizations.Country, Organizations.Adress,  Organizations.Phone, Organizations.Email, 
dbo.GetPetCount(2,Organizations.IDOrganization) as PetsCount, 
dbo.GetCatDogCount(2,Organizations.IDOrganization,1) as CatCount, dbo.GetCatDogCount(2,Organizations.IDOrganization,2) as DogCount
FROM Organizations 
Where dbo.GetPetCount(2,Organizations.IDOrganization) > 0";

            if (filtersNames.Keys.Count != 0)
            {
                query += " and ";

                List<string> filterQuery = new List<string>();

                foreach (var key in filtersNames.Keys)
                {
                    string filterKey = "(";
                    if (key == "petsNumberFrom")
                    {
                        filterKey += "dbo.GetPetCount(2,Organizations.IDOrganization) > '" + filtersNames["petsNumberFrom"][0] + "'";
                    }
                    if (key == "petsNumberTo")
                    {
                        filterKey += "dbo.GetPetCount(2,Organizations.IDOrganization) < '" + filtersNames["petsNumberTo"][0] + "'";
                    }
                    if (key == "catsNumberFrom")
                    {
                        filterKey += "dbo.GetCatDogCount(2,Organizations.IDOrganization,1) > '" + filtersNames["catsNumberFrom"][0] + "'";
                    }
                    if (key == "catsNumberTo")
                    {
                        filterKey += "dbo.GetCatDogCount(2,Organizations.IDOrganization,1) < '" + filtersNames["catsNumberTo"][0] + "'";
                    }
                    if (key == "dogsNumberFrom")
                    {
                        filterKey += "dbo.GetCatDogCount(2,Organizations.IDOrganization,2) > '" + filtersNames["dogsNumberFrom"][0] + "'";
                    }
                    if (key == "dogsNumberTo")
                    {
                        filterKey += "dbo.GetCatDogCount(2,Organizations.IDOrganization,2) < '" + filtersNames["dogsNumberTo"][0] + "'";
                    }
                    if (key == "Organizations.Country")
                    {
                        for (int i = 0; i < filtersNames[key].Count; i++)
                        {
                            filterKey += key + " = '" + filtersNames[key][i] + "'";

                            if (i != filtersNames[key].Count - 1) filterKey += " or ";
                        }
                    }

                    filterKey += ")";
                    filterQuery.Add(filterKey);
                }

                for (int i = 0; i < filterQuery.Count; i++)
                {
                    query += filterQuery[i];

                    if (i == filterQuery.Count - 1) query += ";";
                    else query += " and ";
                }
            }

            DataTable data = Database.ExecuteQuery(query);
            return data;
        }
    }
}
