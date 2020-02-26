using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{

    public class PriceAskingService : IPriceAskingService
    {
        private PriceAskingDao _dao;

        public PriceAskingService()
        {
            _dao = new PriceAskingDao();
        }
        public string GetPriceAskigListByBladId(int bladid)
        {
            return _dao.GetPriceAskigListByBladId(bladid);
        }

        public Task<int> CreatePriceAskingEntry(tblPriceAsking asking)
        {
            return _dao.CreatePriceAskingEntry(asking);
        }
    }
}