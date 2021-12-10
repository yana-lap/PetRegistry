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
            string query = "select * from Pets;";
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
