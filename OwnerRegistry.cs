using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PetRegistry
{
    class OwnerRegistry
    {
       public DataTable OpenOwnersUserRegistry(Dictionary<string, List<string>> filtersNames)
       {
            return OwnerService.GetOwnersUserRegistry(filtersNames);
        }

        public DataTable OpenOwnersOrgRegistry(Dictionary<string, List<string>> filtersNames)
        {
            return OwnerService.GetOwnersOrgRegistry(filtersNames);
        }
    }
}
