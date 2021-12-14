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

       

        public Pet OpenPetCard(string cardNumber)
        {
            DataTable data = petRegistry.OpenPetCard(cardNumber);
            Pet currentPet = new Pet(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), DateTime.Parse(data.Rows[0][3].ToString()), data.Rows[0][4].ToString(),
                data.Rows[0][5].ToString(), DateTime.Parse(data.Rows[0][6].ToString()), data.Rows[0][7].ToString(), data.Rows[0][8].ToString(),
                DateTime.Parse(data.Rows[0][9].ToString()), DateTime.Parse(data.Rows[0][10].ToString()), DateTime.Parse(data.Rows[0][11].ToString()),
                DateTime.Parse(data.Rows[0][12].ToString()), data.Rows[0][13].ToString(), data.Rows[0][14].ToString(), data.Rows[0][15].ToString(), data.Rows[0][16].ToString());
            
            return currentPet;
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

        public string UpdatePetData(string cardNumber, string[] data)
        {
            if (roleIsMaching("изменение"))
            {
                Pet pet = new Pet();
                return pet.UpdatePetData(cardNumber, data);
            }
            else return "Недостаточно прав.";
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
