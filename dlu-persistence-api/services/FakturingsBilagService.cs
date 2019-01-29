using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class FakturingsBilagService: IFakturingBilagService
    {
        private FakturingsBilagDao _bilagDao;

        public FakturingsBilagService()
        {
            _bilagDao = new FakturingsBilagDao();
        }
        
        public string GetFakturingsBilagByMedieId(int medieId)
        {
            return _bilagDao.GetFakturingsBilagByMedieId(medieId);
        }

        public string GetFakturingsBilagByOprettetAf(string oprettetAf)
        {
            return _bilagDao.GetFakturingsBilagByOprettetAf(oprettetAf);
        }

        public Task<int> OpretFakturingsBilag(tblFaktureringsBilag tblFaktureringsBilag)
        {
            return _bilagDao.OpretFakturingsBilag(tblFaktureringsBilag);
        }
    }
}