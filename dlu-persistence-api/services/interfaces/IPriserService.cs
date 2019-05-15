using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IPriserService
    {
     
         string GetPrisLigePrUge(int bladId, int year);
        Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl);
        string GetPrisLister();
        Task<int> AddPriserPrUge(int bladid, int prislisteId);
        Task<int> CreatePrice(tblPriser tblPriser);
        string GetPlacering();
        string GetPriserFromBladId(int bladId);
        string GetPrisListeFromBladidArPlacering(int bladId, int placering, int aar);
    }
}