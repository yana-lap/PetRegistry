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
