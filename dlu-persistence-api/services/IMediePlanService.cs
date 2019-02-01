using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanService
    {
        string GetMediePlanById(int id);
        string GetMediePlanByKontakt(string name);

        
        Task<int> CreateOrUpdate(tblMedieplan tblMedieplan);
    }
}