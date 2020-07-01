using dlu_persistence_api.daos;
using dlu_persistence_api.models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class AnnoceKontrolService : IAnnonceKontrolService
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

        public List<AnnoceKontrol> GetSQLAnnoceKontrols()
        {
            return _dao.GetSQLAnnoceKontrols();
        }

        public List<AnnoceKontrol> GetSQLAnnoceKontrolsByWeek(int uge)
        {
            return _dao.GetSQLAnnoceKontrolsByWeek(uge);
        }
    }
}