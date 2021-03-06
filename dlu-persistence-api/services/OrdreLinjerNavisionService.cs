using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class OrdreLinjerNavisionService : IOrdreLinjerNavisionService
    {
        private OrdreLinjerNavisionDao _dao;

        public OrdreLinjerNavisionService()
        {
            _dao = new OrdreLinjerNavisionDao();
        }
        public string GetOrderLinerByBladID(int bladId)
        {
            return _dao.GetOrderLinerByBladID(bladId);
        }

        public string GetOrderLinjerByBureaOrderNr(string bureaorderne)
        {
            return _dao.GetOrderLinjerByBureaOrderNr(bureaorderne);
        }

        public Task<int> CreateOrUpdate(tblOrdreLinjerNavision tblOrdreLinjerNavision)
        {
            return _dao.CreateOrUpdate(tblOrdreLinjerNavision);
        }
    }
}