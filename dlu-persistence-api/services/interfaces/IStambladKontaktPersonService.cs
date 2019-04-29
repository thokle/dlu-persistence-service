using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IStambladKontaktPersonService
    {
        string GetStamBladKontakterByStambladId(int bladId);
        Task<int> AddOrUpdateStamBladKontkt(tblStambladKontakter tblStambladKontakter);

    }
}