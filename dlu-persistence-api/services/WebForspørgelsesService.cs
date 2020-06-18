using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class WebForspørgelsesService : IWebForspørgelsesService
    {
        private WebForespørgselDao _forespørgselDao;

        public WebForspørgelsesService()
        {
            _forespørgselDao = new WebForespørgselDao();
        }
        public string GetWebForespørgselByMedieplanNr(int mediePlanNr)
        {
            return _forespørgselDao.GetWebForespørgselByMedieplanNr(mediePlanNr);
        }

        public string GetWebForespørgselByAnnoncørNo(string annoncørid)
        {
            return _forespørgselDao.GetWebForespørgselByAnnoncørNo(annoncørid);
        }

        public string GetWebForespørgselByMediebureau(string burea)
        {
            return _forespørgselDao.GetWebForespørgselByMediebureau(burea);
        }

        public Task<int> CreateOrUpdate(tblWEBForespørgsel forespørgsel)
        {
            return _forespørgselDao.CreateOrUpdate(forespørgsel);
        }

        public int GetLastCreateId()
        {
            return _forespørgselDao.GetLastCreateId();
        }
    }
}