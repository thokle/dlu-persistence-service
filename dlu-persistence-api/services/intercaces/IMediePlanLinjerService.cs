using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanLinjerService
    {
        string GetMediePlanLinjerByMedieId(int medieoid);
        Task<int> CreateOrUpDate(tblMedieplanLinjer tblMedieplanLinjer);
    }
}