using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{

    public class FejlTekstService : IFejlTekstService
    {


        private FejlTekstDao _fejlTekstDao;

        public FejlTekstService()
        {
            _fejlTekstDao = new FejlTekstDao();

        }
        public string GetFejlTekstDaoByMedieId(int medieId)
        {

            return _fejlTekstDao.GetFejlTekstDaoByMedieId(medieId);
        }

        public Task<int> CreateOrUpDateFejlTekst(tblFakturaFejl t)
        {

            return _fejlTekstDao.CreateOrUpDateFejlTekst(t);
        }

        public string GetFejlodeTekstDaoByAnsvarlig(string ansvartlig)
        {
            return _fejlTekstDao.GetFejlodeTekstDaoByAnsvarlig(ansvartlig);
        }
    }
}