using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class SupportBilagService
    {
        private SupportBilagDao _dao;

        public SupportBilagService()
        {
            _dao = new SupportBilagDao();
        }
        public SupporBillag GetSupportBilagByMedieId(int medieId)
        {
            return _dao.GetSupportBilagByMedieId(medieId: medieId);
        }

        public int CreateOrUpdate(tblSupportBilag tblSupportBilag)
        {
            return _dao.CreateOrUpdate(tblSupportBilag);
        }
    }
}