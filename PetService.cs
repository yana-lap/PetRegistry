using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PetRegistry
{
    static class PetService
    {

       
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

        public static DataTable GetMyPets(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            string query = @"select Pets.IDPet, Categories.CategoryName, Pets.PetName, Pets.BirthDate, Pets.Breed, Pets.RegistrationDate, Pets.PassportNum, Users.UserName
from Pets
inner join Categories on Pets.Category = Categories.IDCategory
inner
join Users on Pets.OwnerUser = Users.IDUser
Where Pets.OwnerUser = '" +Variables.CurrentUser.ID+"'";
            return Database.ExecuteQuery(query);
        }
        public static DataTable GetPetCard(int cardNumber)
        {
            string query = "select * from Pets Where IDPet ='"+cardNumber+"';";
            return Database.ExecuteQuery(query);         
        }
        public static void AddNewPet(string[] newPet)
        {
            string query = @"insert into Pets (PetName, Category, Breed, Gender, BirthDate, RegistrationDate, PassportNum, IdentificationNum, ChipNum, VacinationDate,
VacinationDateEnd, DewormingDate, DewormingDateEnd, VetAppointments, Photo, OwnerType, OwnerUser, OwnerCompany) values ('" + newPet[0]+ "', "+ newPet[1] + ", '"+ newPet[2] + 
"', '"+ newPet[3] + "', '" + newPet[4] + "', '" + newPet[5] + "', '" + newPet[6] + "', '" + newPet[7] + "', '" + newPet[8] + "', '" + newPet[9] + "', '" + newPet[10] + "', '" 
+ newPet[11] + "', '" + newPet[12] + "', '" + newPet[13] + "', NULL, " + newPet[14] + ", " + newPet[15] + ", " + newPet[16] +")";
            Database.ExecuteNonQuery(query);
        }

        public static void DeleteCard(int cardNumber)
        {
            string query = @"Delete From Pets Where IDPet=" + cardNumber + ";";
            Database.ExecuteNonQuery(query);
        }

        public static void ChangePetData(long cardNumber, string[] data)
        {
 
        }
    }
}
