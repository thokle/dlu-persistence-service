using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    interface IBladTilaegsTypeService
    {
         string GetBladtillaegsTyper();
        Task<int> CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType);
    }
}