using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    static class PetService
    {

        public static void DeleteCard(long cardNumber)
        {         

        }
        public static DataTable GetPets(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {
            string query = "select Pets.IDPet, Categories.CategoryName, Pets.Gender, Pets.BirthDate, Pets.IdentificationNum, Pets.ChipNum," +
                " Pets.PetName, Pets.Photo, dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany) as OwnerPet from Pets" +
                " inner join Categories on Pets.Category = Categories.IDCategory";
            return Database.ExecuteQuery(query);

            /*string query1 = @"select Pets.IDPet, Categories.CategoryName, Pets.Gender, Pets.BirthDate, Pets.IdentificationNum, Pets.ChipNum, 
 Pets.PetName, Pets.Photo, Users.UserName as OwnerPet from Pets
 inner join Categories on Pets.Category = Categories.IDCategory
 inner join Users on Pets.OwnerUser = Users.IDUser
 Where OwnerType = '1'";
             string query2 = @"select Pets.IDPet, Categories.CategoryName, Pets.Gender, Pets.BirthDate, Pets.IdentificationNum, Pets.ChipNum, 
 Pets.PetName, Pets.Photo, Organizations.OrgName as OwnerPet from Pets
 inner join Categories on Pets.Category = Categories.IDCategory
 inner join Organizations on Pets.OwnerCompany = Organizations.IDOrganization
 Where OwnerType = '2'";

             DataTable dataTable = Database.ExecuteQuery(query1);
             DataTable dataTableOrg = Database.ExecuteQuery(query2);

             dataTable.Merge(dataTableOrg);

             return dataTable;*/
            
        }
        public static DataTable GetPetCard(int cardNumber)
        {
            string query = "select * from Pets Where IDPet ='"+cardNumber+"';";
            return Database.ExecuteQuery(query);         
        }
        public static void AddNewPet(Pet newPet)
        {

        }
        public static void ChangePetData(long cardNumber, string[] data)
        {
 
        }
    }
}
