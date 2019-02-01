using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class SupportBilagService: ISupportBilagService
    {
        private SupportBilagDao _dao;

        public SupportBilagService()
        {
            _dao = new SupportBilagDao();
        }
        public string GetSupportBilagByMedieId(int medieId)
        {
            return _dao.GetSupportBilagByMedieId(medieId: medieId);
        }

        public Task<int> CreateOrUpdate(tblSupportBilag tblSupportBilag)
        {
            return _dao.CreateOrUpdate(tblSupportBilag);
        }
    }
}