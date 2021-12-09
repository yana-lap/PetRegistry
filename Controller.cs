using System;
using System.Collections.Generic;
using System.Text;

namespace PetRegistry
{
    class Controller
    {
        public void Login(string login, string password)
        {

        }  
        public void OpenPetsRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {

        }
        public void OpenPetCard(string cardNumber)
        {

        } 
        public void ExportPetRegistryToExcel(string pathToFile, Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {

        }
        public void ExportPetCardToWord(string pathToFile, long cardNumber, long documentType)
        {

        } 
        public void GetRabiesVaccineData(string pathToFile, Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {

        }
        public void RegisterNewPet(string[] data)
        {

        }

        public void UpdatePetData(long cardNumber, string[] data)
        {
 
        }
        public void DeletePetCard(string cardNumber)
        {

        }
        private bool roleIsMaching(string operation)
        {
            return true;
        }        
    }
}
