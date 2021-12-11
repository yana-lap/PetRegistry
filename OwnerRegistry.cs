using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    class OwnerRegistry
    {
       public DataTable OpenOwnersUserRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
       {
            return OwnerService.GetOwnersUserRegistry(filtersNames, sortNames);
        }

        public DataTable OpenOwnersOrgRegistry(Dictionary<string, string[]> filtersNames, Dictionary<string, string[]> sortNames)
        {
            return OwnerService.GetOwnersOrgRegistry(filtersNames, sortNames);
        }
    }
}
