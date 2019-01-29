using System.Threading.Tasks;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class FakturaFejlTekstService: IFakuraFejlTekstService
    {
        private FakuraFejlTekstDao _fejlTekstDao;

        public FakturaFejlTekstService()
        {
            _fejlTekstDao = new FakuraFejlTekstDao();
        }
        
        public string GetFejlTekster()
        {
            return _fejlTekstDao.GetFejlTekster();
        }

        public Task<int> CreateOrUpDate(tblFakturaFejlTekst tblFakturaFejlTekst)
        {
            return _fejlTekstDao.CreateOrUpDate(tblFakturaFejlTekst);
        }
    }
}