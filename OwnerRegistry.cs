using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    class OwnerRegistry
    {
       public DataTable OpenOwnersUserRegistry(Dictionary<string, List<string>> filtersNames, Dictionary<string, List<string>> sortNames)
       {
            return OwnerService.GetOwnersUserRegistry(filtersNames, sortNames);
        }

        public DataTable OpenOwnersOrgRegistry(Dictionary<string, List<string>> filtersNames, Dictionary<string, List<string>> sortNames)
        {
            return OwnerService.GetOwnersOrgRegistry(filtersNames, sortNames);
        }
    }
}
