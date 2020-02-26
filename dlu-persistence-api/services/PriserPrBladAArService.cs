using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class PriserPrBladAArService : IPriserPrBladAArService
    {

        private PriserBladPrAarDao _priserBladPr;

        public PriserPrBladAArService()
        {
            _priserBladPr = new PriserBladPrAarDao();
        }
        public Task<int> createPriceBladPrAAr(tblPrislisterPrBladPrÅr tblPrislisterPrBladPrÅr)
        {
            return _priserBladPr.createPriceBladPrAAr(tblPrislisterPrBladPrÅr);
        }

    }

}



