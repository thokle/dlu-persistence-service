using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IOrdreGebyrNavisionService
    {
        string GetOrderGebyNavisionByOrderId(int orderid);
     
        string GetOrderGebyNavisionBySælgerkode(string saelgerkode);
        string GetOrderNavisionGebyrByBureau(string burea);
        Task<int> CreateOrUpate(tblOrdreGebyrNavision tblOrdreGebyrNavision);
    }
}
    