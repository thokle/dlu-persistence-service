using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    interface IBladTilaegsServcie
    {
        string GetTillaegsTypeByBladId(int bladid);
        Task<int> CreateOrUpdate(tblBladTillaeg tblBladTillaeg);
    }
}