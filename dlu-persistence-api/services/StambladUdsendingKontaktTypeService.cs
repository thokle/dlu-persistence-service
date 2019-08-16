using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class StambladUdsendingKontaktTypeService : IStambladUdsendingKontaktTypeService
    {
        private StambladUdsendingKontaktTyperDao kontakterDao;


        public StambladUdsendingKontaktTypeService()
        {
            kontakterDao = new StambladUdsendingKontaktTyperDao();
        }
        public string GetStamBladUdsendingKontaktType()


        {
            return kontakterDao.GetStamBladUdsendingKontaktType();
        }
    }
}
