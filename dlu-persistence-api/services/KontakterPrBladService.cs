using dlu_persistence_api.daos;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class KontakterPrBladService: IKontakterPrBladService
    {

        private KontakterPrBladDao _kontakterPrBladDao;

        public KontakterPrBladService()
        {
            
            _kontakterPrBladDao = new KontakterPrBladDao();
            
        }
        public Task<int> CreateOrUpdateKontakterPrBlad(tblKontakterPrBlad tblKontakterPrBlad)
        {
            return _kontakterPrBladDao.CreateOrUpdateKontakterPrBlad(tblKontakterPrBlad);
        }
    }
}