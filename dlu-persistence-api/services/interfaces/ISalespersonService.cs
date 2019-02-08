using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface ISalespersonService
    {
        string GetSalesPersonByEmail(string email);
        string GetSalesPersonByName(string name);
        Task<int> CreateOrUpdate(Salesperson salesperson);
    }
}