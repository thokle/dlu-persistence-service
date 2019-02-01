using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface ISupportBilagService
    {
        string GetSupportBilagByMedieId(int medieId);
        Task<int> CreateOrUpdate(tblSupportBilag tblSupportBilag);
    }
}