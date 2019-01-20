using System.Threading.Tasks;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class BladDækningService : IBladDæknigService
    {
        private readonly BladDækningDao _dao;

        public BladDækningService()
        {
            _dao = new BladDækningDao();
        }

        public string GetBladDækningByBladId(int bladId)
        {
            return _dao.GetDækningGradByBladId(bladId);
        }

        public string GetBladDækningByPostnr(int postnr)
        {
            return _dao.GetDækningGrapPrPostNr(postnr);
        }

        public Task<int> OpretBladDækning(tblBladDækning tblBladDækning)
        {
            return _dao.OpretBladDækning(tblBladDækning);
        }
    }
}