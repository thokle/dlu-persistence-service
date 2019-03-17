using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IStambladKontaktPersonService
    {
        string GetKontaktPersonerByBladID(int bladId);
        Task<int> CreateOrUpdateKontaktPerson(StamBladKontaktPersoner personer);

    }
}