using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    class PetRegistry
    {
        public DataTable OpenPetsRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {
            DataTable data = PetService.GetPets(filtersNames, sortNames);

            return data;
        }
        public DataTable OpenMyPetsRegistry(Dictionary<string, string[]> filtersNames = null, Dictionary<string, string[]> sortNames = null)
        {
            DataTable data = PetService.GetMyPets(filtersNames, sortNames);
            return data;
        }

        public DataTable OpenPetCard(int cardNumber)
        {
            return PetService.GetPetCard(cardNumber); 
        }

        public void DeletePetCard(int cardNumber)
        {
            PetService.DeleteCard(cardNumber);
        }


    }
}
