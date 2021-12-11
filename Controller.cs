using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PetRegistry
{
    class Controller
    {
        PetRegistry petRegistry = new PetRegistry();
        OwnerRegistry ownerRegistry = new OwnerRegistry();
        public void Login(string login, string password)
        {
            Authorization authorization = new Authorization();

            if (login != "" && password != "" && authorization.Login(login, password))
            {
                Form registryForm = new RegistryForm();
                registryForm.ShowDialog();
            } else
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }  
        public DataTable OpenPetsRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = petRegistry.OpenPetsRegistry(filtersNames, sortNames);
            return data;
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
