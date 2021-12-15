using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    class PetRegistry
    {
        public DataTable OpenPetsRegistry(Dictionary<string, List<string>> filtersNames, Dictionary<string, List<string>> sortNames)
        {
            DataTable data = PetService.GetPets(filtersNames, sortNames);

            return data;
        }
        public DataTable OpenMyPetsRegistry(Dictionary<string, List<string>> filtersNames = null, Dictionary<string, List<string>> sortNames = null)
        {
            DataTable data = PetService.GetMyPets(filtersNames, sortNames);
            return data;
        }

        public DataTable OpenPetCard(string cardNumber)
        {
            return PetService.GetPetCard(cardNumber); 
        }

        public void DeletePetCard(int cardNumber)
        {
            PetService.DeleteCard(cardNumber);
        }


    }
}
