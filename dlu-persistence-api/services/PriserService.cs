using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class PriserService: IPriserService

    {

        private PriserDao _dao;

        public PriserService()
        {
            _dao = new PriserDao();
          
        }
      

        public string GetPrisLigePrUge(int bladId)
        {
            return _dao.GetPrisLigePrUge(bladId);
        }

        public Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            return _dao.CreateOrUpdatePrisListePrBladPrÅr(tbl);
        }

        public string GetPrisLister()
        {
            return _dao.GetPrisLister();
        }

        public Task<int> AddPriserPrUge(int bladid, int prislisteId)
        {
            return _dao.AddPriserPrUge(bladid, prislisteId);
        }

        public Task<int> CreatePrice(tblPriser tblPriser)
        {
            return _dao.CreatePrice(tblPriser);
        }

        public string GetPlacering()
        {
            return _dao.GetPlacering();
        }

        public string GetPriserFromBladId(int bladId)
        {
            return _dao.GetPriserFromBladId(bladId);
        }

        public string GetPrisListeFromBladidArPlacering(int bladId, int placering, int aar)
        {
            return _dao.GetPrisListeFromBladidArPlacering(bladId, placering, aar);
        }
    }
}