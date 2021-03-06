using dlu_persistence_api.daos;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class BladDækningService
    {
        private readonly BladDækningDao _dao;

        public BladDækningService()
        {
            _dao = new BladDækningDao();
        }



        public string GetBladDækningByPostnr(int postnr)
        {
            return _dao.GetDækningGrapPrPostNr(postnr);
        }

        public Task<int> OpretBladDækning(tblBladDækning tblBladDækning)
        {
            return _dao.OpretBladDækning(tblBladDækning);
        }

        public int DeleteDaeking(int bladid, int postnr)
        {
            return _dao.DeleteDaeking(bladid, postnr);
        }
    }
}