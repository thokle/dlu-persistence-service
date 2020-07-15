using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    public interface INewPriserService
    {
        int TruncateTable();
        List<tableNewPriserMeldtInd> ResettableNewPriserMeldtInds();
        int UpDateStatus(string email);
    }
}
