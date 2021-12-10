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
        public DataTable OpenPetCard(string cardNumber)
        {
            return null;
        }
        
    }
}
