using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IPriceAskingService
    {
        string GetPriceAskigListByBladId(int bladid);
        Task<int> CreatePriceAskingEntry(tblPriceAsking asking);
    }
}