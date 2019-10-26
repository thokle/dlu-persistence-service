using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
using System.Collections.Generic;
namespace dlu_persistence_api.services
{
    public class StambladUdsendingKontaktTypeService
    {
        private StambladUdsendingKontaktTyperDao kontakterDao;


        public StambladUdsendingKontaktTypeService()
        {
            kontakterDao = new StambladUdsendingKontaktTyperDao();
        }
        public List<StambladUdsendingEmailTyper> GetStamBladUdsendingKontaktType()


        {
            return kontakterDao.GetStamBladUdsendingKontaktType();
        }
    }
}
