using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
   public interface IPrisUdsendingService
    {
        List<Udsending> GetAllStambladTilUdsending();
        List<Udsending> GetAllStambladTilUdsendingTilDeadlines();

        List<models.Ejerforhold> GetAllDistinctEjerforhold();
    }
}
