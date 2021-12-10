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
            string query = "select * from Pets";
            DataTable data = Database.ExecuteQuery(query);

            return data;
        }
        public static void GetPetCard(long cardNumber)
        {

        }
        public static void AddNewPet(Pet newPet)
        {

        }
        public static void ChangePetData(long cardNumber, string[] data)
        {
 
        }
    }
}
