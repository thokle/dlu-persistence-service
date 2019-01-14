using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanNrService
    {
        string GetMediePlanNrByMedIePlanNr(int mediePlannr);
        Task<int> CreateOrUpsateMediePlanNr(tblMedieplanNr tblMedieplanNr);
    }
}