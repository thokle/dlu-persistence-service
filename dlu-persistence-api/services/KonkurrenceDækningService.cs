using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class KonkurrenceDækningService

    {
        private KonkurrenceDaekningDao _konkurrenceDaekningDao;

        public KonkurrenceDækningService()
        {
            _konkurrenceDaekningDao = new KonkurrenceDaekningDao();
        }
        
        public string GetKomkurrenceDækningPrPostNr(int postnr)
        {

            return _konkurrenceDaekningDao.GetKomkurrenceDækningPrPostNr(postnr);
        }

        public string GetKonkurrenceDækningPrDaeknngGrad(int daekg)
        {
            return _konkurrenceDaekningDao.GetKonkurrenceDækningPrDaeknngGrad(daekg);
        }

        public Task<int> CreateOrUpdate(tblKonkurrentDækning tblKonkurrentDækning)
        {
            return _konkurrenceDaekningDao.CreateOrUpdate(tblKonkurrentDækning);
        }

        public System.Collections.Generic.List<KonkurentDaekningDao> GetKonkurrenter(byte konkurrentid)
        {
            return _konkurrenceDaekningDao.GetKonkurrenterById(konkurrentid);
        }
    }
}