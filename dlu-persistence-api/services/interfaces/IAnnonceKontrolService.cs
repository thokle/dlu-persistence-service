using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IAnnonceKontrolService
    {
        string GetAnnoceKontrolByMediePlanId(int mediePlanId);
        string GetAnnonceKontrolByEmail(string email);
        Task<int> CreateOrUpdate(tblAnnoncekontrol tblAnnoncekontrol);
    }
}