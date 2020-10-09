using dlu_persistence_api.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IAnnonceKontrolService
    {
        string GetAnnoceKontrolByMediePlanId(int mediePlanId);
        string GetAnnonceKontrolByEmail(string email);
        int CreateOrUpdate(tblAnnoncekontrol tblAnnoncekontrol);

         List<AnnoceKontrol> GetSQLAnnoceKontrols();
        List<AnnoceKontrol> GetSQLAnnoceKontrolsByWeek(int uge);
    }
}