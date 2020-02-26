using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class SalesPersonService : ISalespersonService
    {
        public string GetSalesPersonByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public string GetSalesPersonByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CreateOrUpdate(Salesperson salesperson)
        {
            throw new System.NotImplementedException();
        }
    }
}