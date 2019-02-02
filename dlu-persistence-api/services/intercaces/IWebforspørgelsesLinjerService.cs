using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IWebforspørgelsesLinjerService
    {
        string GetForspørgelsesLinjerByBladId(int bladID);
        Task<int> CreateOrUpdate(tblWEBForespørgselLinjer forespørgselLinjer);
    }
}