using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IBladDæknigService
    {
        string GetBladDækningByPostnr(int postnr);
        Task<int> OpretBladDækning(tblBladDækning tblBladDækning);
        Task<int> DeleteDaeking(int bladid, int postnr);
    }
}