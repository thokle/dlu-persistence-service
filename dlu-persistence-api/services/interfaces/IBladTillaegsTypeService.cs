using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
   public interface IBladTillaegsTypeService
    {
        string GetBladTilKLaegs(int bladid);
        Task<int> CreateBladTillaegs(tblBladTiLaegsType tblBladTiLaegsType);


    }
}
