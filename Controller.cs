using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace PetRegistry
{
    class Controller
    {
        PetRegistry petRegistry = new PetRegistry();
        OwnerRegistry ownerRegistry = new OwnerRegistry();
        public bool Login(string login, string password)
        {
            Authorization authorization = new Authorization();

            return (login != "" && password != "" && authorization.Login(login, password));
        }  
        public DataTable OpenPetsRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = petRegistry.OpenPetsRegistry(filtersNames, sortNames);
            return data;
        }
        public DataTable OpenMyPetsRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = petRegistry.OpenMyPetsRegistry(filtersNames, sortNames);
            return data; //после создания фильтров снести метод, объединив с OpenPetsRegistry
        }
        public DataTable OpenOwnersUserRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = ownerRegistry.OpenOwnersUserRegistry(filtersNames, sortNames);
            return data;
        }
        public DataTable OpenOwnersOrgRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = ownerRegistry.OpenOwnersOrgRegistry(filtersNames, sortNames);
            return data;
        }

       

        public void OpenPetCard(string cardNumber)
        {
            DataTable data = petRegistry.OpenPetCard(Int32.Parse(cardNumber));

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
        public string RegisterNewPet(string[] data)
        {
            if (roleIsMaching("добавление"))
            {
                Pet newPet = new Pet();
                return  newPet.RegisterNewPet(data);
            }
            else { return "Недостаточно прав."; }
        }

        public void UpdatePetData(string cardNumber, string[] data)
        {
 
        }
        public string DeletePetCard(string cardNumber)
        {
            if (roleIsMaching("удаление"))
            {
                petRegistry.DeletePetCard(Convert.ToInt32(cardNumber));
                return "Удаление завершено.";
            } else return "Недостаточно прав.";

        }
        public bool roleIsMaching(string operation)
        {
            return Variables.MatchingRoles[operation].Contains(Variables.CurrentUser.Role);
        }        
    }
}
