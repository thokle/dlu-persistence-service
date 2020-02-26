using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    interface IStambladKontakterService
    {
        string GetStamBladKontakterByStambladId(int stambladid);
        Task<int> AddOrUpdateStamBladKontkt(tblStambladKontakter tblStambladKontakter);
    }
}
