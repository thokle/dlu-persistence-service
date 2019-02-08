using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IPriserService
    {
        string GetPrislisterPrÅrByBladId(int bladid);
        string GetPrisLigePrUge(int bladId);
        Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl);
        string GetPrisLister();
        Task<int> AddPriserPrUge(int bladid);
    }
}