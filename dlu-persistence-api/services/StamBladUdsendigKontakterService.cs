using dlu_persistence_api.daos;
using dlu_persistence_api.models;
using dlu_persistence_api.services.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class StamBladUdsendigKontakterService: IStamBladUdsendigKontakterService
    {
        private StamBladUdsendigKontakterDao kontakterDao;

        public StamBladUdsendigKontakterService()
        {
            kontakterDao = new StamBladUdsendigKontakterDao();
        }
        public Task<int> AddOrUpdateKontakterPrBlad(tblBladUdsendingKontakter tblBlad)
        {
            return kontakterDao.AddOrUpdateKontakterPrBlad(tblBlad);

        }

        public List<UdsendingKontakter> GetUdsendingKontakterPrBladId(int bladId)
        {
            return kontakterDao.GetUdsendingKontakterPrBladId(bladId);
        }
    }
}
