using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class PriserService: IPriserService

    {

        private PriserDao _dao;

        public PriserService()
        {
            using (_dao = new PriserDao()) ;
        }
        public string GetPrislisterPrÅrByBladId(int bladid)
        {
            return _dao.GetPrislisterPrÅrByBladId(bladid);
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

        public Task<int> AddPriserPrUge(int bladid)
        {

            return _dao.AddPriserPrUge(bladid);
        }
    }
}