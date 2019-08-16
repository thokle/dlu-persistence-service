using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;

namespace dlu_persistence_api.services
{
    public class StamBladUdsendigKontakterService : IStamBladUdsendigKontakterService
    {
        private StamBladUdsendigKontakterDao kontakterDao;

        public StamBladUdsendigKontakterService()
        {
            kontakterDao = new StamBladUdsendigKontakterDao();
        }
        public Task<int> AddOrUpdateKontakterPrBlad(tblBladUdsendingKontakter tblBlad)
        {
            return  kontakterDao.AddOrUpdateKontakterPrBlad(tblBlad);

        }

        public string GetUdsendingKontakterPrBladId(int bladId)
        {
            return kontakterDao.GetUdsendingKontakterPrBladId(bladId);
        }
    }
}
