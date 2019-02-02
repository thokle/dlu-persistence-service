using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IKontakterPrBladService
    {
        Task<int> CreateOrUpdateKontakterPrBlad(tblKontakterPrBlad tblKontakterPrBlad);
    }
}