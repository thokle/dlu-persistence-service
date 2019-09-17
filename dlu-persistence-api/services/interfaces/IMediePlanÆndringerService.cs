using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanÆndringerService
    {
        string GetMediePlanÆndringerByMedieId(int mediePlan, int version);
        Task<int> CreateOrUpdate(tblMedieplanÆndringer tblMedieplanÆndringer);
    }
}