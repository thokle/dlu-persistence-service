using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IOrdreLinjerNavisionService
    {
        string GetOrderLinerByBladID(int bladId);
        string GetOrderLinjerByBureaOrderNr(string bureaordernr);
        Task<int> CreateOrUpdate(tblOrdreLinjerNavision tblOrdreLinjerNavision);
    }
}