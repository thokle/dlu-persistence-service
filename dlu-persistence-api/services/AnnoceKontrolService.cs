using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class AnnoceKontrolService: IAnnonceKontrolService
    {
        private AnnoncekontrolDao _dao;

        public AnnoceKontrolService()
        {
            
            _dao = new AnnoncekontrolDao();
        }
        public string GetAnnoceKontrolByMediePlanId(int mediePlanId)
        {
            return _dao.GetAnnoceKontrolByMediePlanId(mediePlanId);
        }

        public string GetAnnonceKontrolByEmail(string email)
        {
            return _dao.GetAnnonceKontrolByEmail(email);
        }

        public Task<int> CreateOrUpdate(tblAnnoncekontrol tblAnnoncekontrol)
        {
            return _dao.CreateOrUpdate(tblAnnoncekontrol);
        }
    }
}