using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
   public interface IPriserPrBladAArService
    {
        Task<int> createPriceBladPrAAr(tblPrislisterPrBladPrÅr tblPrislisterPrBladPrÅr);
    }
}
