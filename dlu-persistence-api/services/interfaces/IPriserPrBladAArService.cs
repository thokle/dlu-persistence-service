using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    public interface IPriserPrBladAArService
    {
        Task<int> createPriceBladPrAAr(tblPrislisterPrBladPrÅr tblPrislisterPrBladPrÅr);
    }
}
